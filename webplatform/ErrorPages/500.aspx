<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="500.aspx.cs" Inherits="webplatform.ErrorPages._500" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>500 - Internal Server Error</title>
	<meta charset="utf-8" />
</head>
<body style="text-align: center;">
    <h1>Oh no! Something has gone bubbling wrong!</h1>
    <p>
        Mr. Fusion is reacting badly to the intervention of too many time streams. 
        <br/>
        Quick hit the <i>backspace</i> button and go... <b><i>Back To The Future</i></b>
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
