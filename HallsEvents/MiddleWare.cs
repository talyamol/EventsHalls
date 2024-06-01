namespace HallsEvents
{
    public class MiddleWare
    {


        private readonly RequestDelegate _next;
        public MiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext content)
        {
            Console.WriteLine("middleware start");
            var shabbat = DateTime.Now.DayOfWeek == DayOfWeek.Saturday;
            if (shabbat)
            {
                content.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            else
            {
                await _next(content);
            }
        }
    }
}
