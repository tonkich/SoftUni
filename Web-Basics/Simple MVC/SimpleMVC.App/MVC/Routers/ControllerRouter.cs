using SimpleHttpServer.Models;
using SimpleMVC.App.MVC.Attributes.Methods;
using SimpleMVC.App.MVC.Controllers;
using SimpleMVC.App.MVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App.MVC.Routers
{
    public class ControllerRouter : IHandleable
    {
        private IDictionary<string, string> getParams;
        private  IDictionary<string, string> postParams;
        private string requestMethod;
        private string controllerName;
        private string actionName;
        private object[] methodParams;
        private HttpRequest request;
        private HttpResponse response;

        public ControllerRouter()
        {
           this.getParams = new Dictionary<string, string>();
           this.postParams = new Dictionary<string, string>();
           this.request = new HttpRequest();
           this.response = new HttpResponse();
        }

        public HttpResponse Handle(HttpRequest request)
        {
            this.request = request;
            this.response = new HttpResponse();
            string requestContent = request.Content;

            this.requestMethod = request.Method.ToString();

            if (requestMethod == "GET")
            {
                string[] getParamsSplitted = request.Url.Split('?');
                if (getParamsSplitted.Length > 1)
                {
                    for (int i = 1; i < getParamsSplitted.Length; i++)
                    {
                        string[] keyAndValue = getParamsSplitted[i].Split('=');
                        string key = keyAndValue[0];
                        string value = keyAndValue[1];
                        getParams.Add(key, value);
                    }
                }
            }

            else if (requestMethod == "POST")
            {
                string[] postContent = request.Content.Split('&');
                foreach (string couple in postContent)
                {
                    string[] splittedContent = couple.Split('=');
                    string key = splittedContent[0];
                    string value = splittedContent[1];
                    postParams.Add(key, value);
                }
            }

            string[] splittedUrl = request.Url.Split('/');

            if (splittedUrl.Length > 2)
            {
                controllerName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(splittedUrl[1]) + "Controller";
                string[] splittedAction = splittedUrl[2].Split('?');
                actionName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(splittedAction[0]);
            }

            else if (splittedUrl.Length == 2)
            {
                controllerName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(splittedUrl[1]) + "Controller";
            }

            MethodInfo method = this.GetMethod();

            if (method == null)
            {
                throw new NotSupportedException("No such method");
            }

            IEnumerable<ParameterInfo> parameters = method.GetParameters();
            this.methodParams = new object[parameters.Count()];
            int index = 0;

            foreach (ParameterInfo param in parameters)
            {
                if (param.ParameterType.IsPrimitive)
                {
                    object value = this.getParams[param.Name];
                    this.methodParams[index] = Convert.ChangeType(
                        value,
                        param.ParameterType);
                    index++;
                }
                else if (param.ParameterType==typeof(HttpRequest))
                {
                    this.methodParams[index] = this.request;
                    index++;
                }
                else if (param.ParameterType == typeof(HttpSession))
                {
                    this.methodParams[index] = request.Session;
                    index++;
                }
                else if (param.ParameterType == typeof(HttpResponse))
                {
                    this.methodParams[index] = this.response;
                    index++;
                }
                else
                {
                    Type bindingModelType = param.ParameterType;
                    object bindingModel = Activator.CreateInstance(bindingModelType);
                    IEnumerable<PropertyInfo> properties = bindingModelType.GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        property.SetValue(
                            bindingModel,
                            Convert.ChangeType(
                                postParams[property.Name],
                                property.PropertyType)
                                );
                    }
                    this.methodParams[index] = Convert.ChangeType(bindingModel,
                        bindingModelType);
                    index++;
                }
            }

            IInvocable actionResult = (IInvocable)this.GetMethod().Invoke(this.GetController(), this.methodParams);
            if (string.IsNullOrEmpty(response.Header.Location))
            {
                response.StatusCode = SimpleHttpServer.Enums.ResponseStatusCode.Ok;
                response.ContentAsUTF8 = actionResult.Invoke();
            }
            ClearParameters();

            return response;
        }
        
        private void ClearParameters()
        {
            this.getParams = new Dictionary<string, string>();
            this.postParams = new Dictionary<string, string>();
        }

        private MethodInfo GetMethod()
        {
            MethodInfo method = null;
            foreach (MethodInfo methodInfo in this.GetSuitableMethods())
            {
                IEnumerable<Attribute> attributes = methodInfo
                    .GetCustomAttributes()
                    .Where(a => a is HttpMethodAttribute);

                if (!attributes.Any())
                {
                    return methodInfo;
                }

                foreach (HttpMethodAttribute attribute in attributes)
                {
                    if (attribute.IsValid(this.requestMethod))
                    {
                        return methodInfo;
                    }
                }
            }
            return method;
        }

        private IEnumerable<MethodInfo> GetSuitableMethods()
        {
            return this.GetController()
                .GetType()
                .GetMethods()
                .Where(m => m.Name == this.actionName);
        }

        private Controller GetController()
        {
            var controllerType = string.Format("{0}.{1}.{2}",
                MvcContext.current.AssemblyName,
                MvcContext.current.ControllersFolder,
                this.controllerName);

            var controller = (Controller)Activator.CreateInstance(Type.GetType(controllerType));
            return controller;

        }
    }
}
