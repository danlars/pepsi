<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="webplatform.ErrorPages.Error404" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>404 - Page cannot be found</title>
	<meta charset="utf-8" />
</head>
<body style="text-align: center;">
    <h1>Mr. Fusion does not exist in the future!</h1>
    <p>
        Quick! Click the <i>backspace</i> button to go <b><i>Back to the Future</i></b>! Fix everything!
    </p>
    
    <span id="countdown"></span>

    <script>
        var seconds = 10;
        var timer = setInterval(countdown, 1000);
        CountDownContent(seconds);

        function countdown() {
            CountDownContent(seconds = seconds - 1);

            if (seconds == 0) {
                clearInterval(timer);
                window.history.back();
            }
        }

        function CountDownContent(time) {
            var txt = "You will be redirected in";
            var CounterTxt = "<h1>" + time + "</h1>";
            document.getElementById("countdown").innerHTML = txt + CounterTxt;
        }

    </script>
</body>
</html>
