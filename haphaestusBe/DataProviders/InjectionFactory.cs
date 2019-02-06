namespace haphaestusBe.DataProviders
{
    /// <summary>
    /// Provides simple DI capabilities
    /// </summary>
    public static class InjectionFactory
    {
        private static IEmployeeDataProvider _employeeDataProvider;
        private static IHttpResponseCreator _httpResponseCreator;

        /// <summary>
        /// Sets the specific <see cref="IEmployeeDataProvider"/> to use for DI
        /// </summary>
        /// <param name="employeeDataProvider">The <see cref="IEmployeeDataProvider"/> to use for DI</param>
        public static void UseIEmployeeDataProvider(IEmployeeDataProvider employeeDataProvider)
        {
            _employeeDataProvider = employeeDataProvider;
        }

        /// <summary>
        /// Gets a <see cref="IEmployeeDataProvider"/>
        /// </summary>
        public static IEmployeeDataProvider GetIEmployeeDataProvider()
        {
            if (_employeeDataProvider is null)
            {
                _employeeDataProvider = new EmployeeDataProvider();
            }

            return _employeeDataProvider;
        }

        /// <summary>
        /// Sets the specific <see cref="IHttpResponseCreator"/> to use for ID
        /// </summary>
        /// <param name="httpResponseCreator">The <see cref="IHttpResponseCreator"/> to use for DI</param>
        public static void UseIHttpResponseCreator(IHttpResponseCreator httpResponseCreator)
        {
            _httpResponseCreator = httpResponseCreator;
        }

        /// <summary>
        /// Gets a <see cref="IHttpResponseCreator"/>
        /// </summary>
        public static IHttpResponseCreator GetIHttpResponseCreator()
        {
            if (_httpResponseCreator is null)
            {
                _httpResponseCreator = new HttpResponseCreator();
            }

            return _httpResponseCreator;
        }
    }
}
