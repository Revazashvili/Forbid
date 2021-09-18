# Forbid
A simple package with extension methods to forbid some value matches,logical values or ranges in .Net

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
* Positive (throws if input is positive number.)
* PositiveOrZero (throws if input is positive number or zero.)
* Negative (throws if input is negative number.)
* NegativeOrZero (throws if input is negative number or zero.)
* MoreThan (throws if input is more than provided value.)
* MoreThanOrEqual (throws if input is more than or equal to provided value.)
* LessThan (throws if input is less than provided value.)
* LessThanOrEqual (throws if input is less than or equal to provided value.)

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

Or

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