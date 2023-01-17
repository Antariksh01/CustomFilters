using Microsoft.AspNetCore.Mvc.Filters;

namespace CustomFilters.Filters
{
    public class MySampleAysncFilterAttribute : Attribute, IAsyncActionFilter
    {
        private readonly string _name;

        public MySampleAysncFilterAttribute(string name)
        {
            _name = name;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"Before Execution - {_name}");
            await next();
            Console.WriteLine($"After Execution - {_name}");
        }
    }
}
