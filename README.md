Sleep for specified time in Windows Console.
> 1. Download [exe file](https://github.com/cmdf/extra-sleep/releases/download/1.0.0/esleep.exe).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
> esleep [options] [<milliseconds>]
:: [-d|--days <days>]
:: [-h|--hours <hours>]
:: [-m|--minutes <minutes>]
:: [-s|--seconds <seconds>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: sleep for 250 milliseconds
> esleep 250

:: sleep for 8 seconds
> esleep 8000

:: sleep for 2 days 8 hours
> esleep -d 2 -h 8
```


[![cmdf](https://i.imgur.com/BAmouMb.jpg)](https://cmdf.github.io)
