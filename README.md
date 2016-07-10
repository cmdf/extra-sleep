# osleep

Sleep for specified time in Windows Console.


## usage

```batch
> osleep [options] [<milliseconds>]
:: [-d|--days <days>]
:: [-h|--hours <hours>]
:: [-m|--minutes <minutes>]
:: [-s|--seconds <seconds>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: sleep for 250 milliseconds
> osleep 250

:: sleep for 8 seconds
> osleep 8000

:: sleep for 2 days 8 hours
> osleep -d 2 -h 8
```
