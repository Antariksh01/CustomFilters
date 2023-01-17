using Microsoft.AspNetCore.Mvc.Filters;

namespace CustomFilters.Filters
{
    public class MySampleFilterAttribute : Attribute ,IActionFilter , IOrderedFilter
    {
        private readonly string _name;

        public MySampleFilterAttribute(string name, int order = 0)
        {
            _name = name;
            Order = order;
        }

        //Order parameter helps in setting the execution order.
        //Lower the value higher the priority
        public int Order { get; set; }  

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"OnActionExecuted-{_name}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"OnActionExecuting- {_name}");
        }
    }
}
