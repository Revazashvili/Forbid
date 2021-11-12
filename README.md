# Forbid
A simple package with extension methods to forbid some value matches,logical values or ranges in .Net

[![.NET](https://img.shields.io/badge/--512BD4?logo=.net&logoColor=ffffff)](https://dotnet.microsoft.com/)
![Nuget](https://img.shields.io/nuget/dt/Forbid?color=blue)
[![NuGet stable version](https://badgen.net/nuget/v/Forbid)](https://www.nuget.org/packages/Forbid)
[![GitHub license](https://badgen.net/github/license/Revazashvili/Forbid)](https://github.com/Revazashvili/Forbid/blob/main/LICENSE)



## Give a Star! :star:
If you like or are using this project please give it a star. Thanks!

## Supported Methods
* Null (throws if input is null.)
* NullOrEmpty (throws if string,guid or IEnumerable<T> is null or empty.)
* NullOrWhitespace (throws if string input is null, empty or whitespace.)
* Zero (throws if number input is zero.)
* True (throws if boolean input is true.)
* False (throws if boolean input is false.)
* Range (throws if input is in provided range.)
* Equal (throws if input is equal to provided value.)
* NotEqual (throws if input is not equal to provided value.)
* Positive (throws if input is positive number.)
* PositiveOrZero (throws if input is positive number or zero.)
* Negative (throws if input is negative number.)
* NegativeOrZero (throws if input is negative number or zero.)
* MoreThan (throws if input is more than provided value.)
* MoreThanOrEqual (throws if input is more than or equal to provided value.)
* LessThan (throws if input is less than provided value.)
* LessThanOrEqual (throws if input is less than or equal to provided value.)
* Any(throws if any element in input satisfies a condition.)

You can pass message or custom exception to methods. 

## Usage

```c#
public class TestClass
{
    private readonly ITestService _testService;
    private readonly int _someValue;
        
    public TestClass(ITestService testService,int someValue)
    {
        _testService = Forbid.From.Null(_testService);
        _someValue = Forbid.From.NegativeOrZero(someValue);
    }
}
```
Or
```c#
public class TestClassWithCustomMessageOrException
{
    private readonly ITestService _testService;
    private readonly int _someValue;
        
    public TestClassWithCustomMessageOrException(ITestService testService,int someValue)
    {
        _testService = Forbid.From.Null(_testService,"test service must not be null.");
        _someValue = Forbid.From.NegativeOrZero(someValue,new CustomException());
    }
}
```
Or you can inject service in DI Container and use IForbid interface.
for this install nuget package [Forbid.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/Forbid.Extensions.Microsoft.DependencyInjection/).
```c#
using Forbids;

public void ConfigureServices(IServiceCollection services)
{
    services.AddForbids(); //default is Singleton, you can pass ServiceLifetime
}
```
and then
```c#
public class TestClassWithDISupport
{
    private readonly IForbid _forbid;
    
    public TestClassWithDISupport(IForbid forbid)
    {
        _forbid = forbid;
    }
    
    public void SomeForbid(int value)
    {
        _forbid.Zero(value);
        // more logic here
    }
}
```

## Extend Forbids
To extend forbids, you can do the following:
```c#
public static class TestExtend
    {
        public static string Test(this IForbid forbid, string input,Exception exception)
        {
            if (input == "test")
                throw exception;
            return input;
        }
    }
```
or you can open a pull request and contribute to my project.