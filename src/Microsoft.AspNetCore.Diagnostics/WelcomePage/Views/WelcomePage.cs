namespace Microsoft.AspNetCore.Diagnostics.Views
{
#line 1 "WelcomePage.cshtml"
using System

#line default
#line hidden
    ;
#line 2 "WelcomePage.cshtml"
using Microsoft.AspNetCore.Diagnostics

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class WelcomePage : Microsoft.AspNetCore.Diagnostics.Views.BaseView
    {
        #line hidden
        public WelcomePage()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 3 "WelcomePage.cshtml"
  
    Response.ContentType = "text/html";

#line default
#line hidden

            WriteLiteral("<!DOCTYPE html>\r\n<html");
            BeginWriteAttribute("lang", " lang=\"", 126, "\"", 208, 1);
#line 7 "WelcomePage.cshtml"
WriteAttributeValue("", 133, System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, 133, 75, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title>");
#line 10 "WelcomePage.cshtml"
      Write(Resources.WelcomeTitle);

#line default
#line hidden
            WriteLiteral(@"</title>
    <style type=""text/css"">
        @font-face {
            font-family: 'SegoeLight', helvetica, sans-serif;
            font-weight: normal;
            font-style: normal;
        }

        body {
            background-color: #00abec;
            color: #fff;
            font-family: 'SegoeLight', helvetica, sans-serif;
            font-size: 18px;
            margin: 0;
            padding: 0;
        }

        .content {
            position: absolute;
            left: 50px;
            top: 38px;
            width: 440px;
        }

            .content .azureLogo {
                margin: 0 0 65px 0;
            }

            .content .bodyHeadline {
                margin: 35px 0 0;
                font-size: 40px;
                line-height: 43px;
            }

            .content .bodyContent {
                margin: 10px 0 30px 0;
                line-height: 22px;
            }

                .content .bodyContent a {
                   ");
            WriteLiteral(@" color: #fff;
                    text-decoration: none;
                }

                    .content .bodyContent a:hover {
                        opacity: .7;
                    }

            .content .bodyCTA {
                color: #fff;
                display: block;
                line-height: 30px;
                height: 29px;
                width: 230px;
                cursor: pointer;
                text-decoration: none;
                position: relative;
            }

                .content .bodyCTA.longer {
                    margin-top: 10px;
                    width: 440px;
                }

                .content .bodyCTA div {
                    position: absolute;
                    overflow: hidden;
                    width: 29px;
                    height: 29px;
                    float: right;
                    top: 0;
                    right: 0;
                }

                    .content .bodyCTA div img {
            ");
            WriteLiteral(@"            position: absolute;
                        top: 0;
                        left: 0;
                        border: 0;
                    }

                .content .bodyCTA:hover div img {
                    left: -29px;
                }

                .content .bodyCTA:hover {
                    opacity: .7;
                }

        .wrapper {
            width: 100%;
            height: 100%;
            overflow: hidden;
            min-width: 1200px;
        }

        .innerwrapper {
            width: 384px;
            height: 100%;
            margin-right: auto;
            margin-left: auto;
        }

        .browser {
            position: absolute;
            display: block;
            top: 400px;
            width: 384px;
            height: 305px;
            cursor: default;
            z-index: 10;
        }

            .browser div {
                width: 384px;
                height: 305px;
                position: absol");
            WriteLiteral(@"ute;
                top: 40px;
                left: 100px;
                font-size: 200px;
                text-align: left;
                -webkit-touch-callout: none;
                -webkit-user-select: none;
                -khtml-user-select: none;
                -moz-user-select: none;
                -ms-user-select: none;
                user-select: none;
            }

        .bulb {
            position: fixed;
            margin-left: 20px;
            top: 0;
        }

        .light {
            position: fixed;
            margin-left: 53px;
            top: 0;
            opacity: 1;
        }

        .bottom {
            position: fixed;
            bottom: 0;
            margin-right: auto;
            margin-left: -303px;
            z-index: -1;
            height: 202px;
        }
    </style>
    <script>
	</script>
</head>
<body>
    <div class=""wrapper"">
        <div class=""innerwrapper"">
            <div class=""light first"">
       ");
            WriteLiteral(@"         <img src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAARIAAAESCAYAAAAxN1ojAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAACKhJREFUeNrs3TFPG0kYgOE1kou4IIVTUITiXJAiFFxBk/8vGopQQBEKKFyci7jAhRsX3E4YB3I5Asva3p2Z55EspJNOOq/3Xn8zu7arCgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAADI1MAhILi/v9+v/wwb/murwWCwcPQQknJCMa7/jOLj3X/+bsKqfiye/F3Gx6KOzcorICSkGY0P9WM/hmK/4/+kZYxLeHwXFyGh3+EYx0cK1lGZh4ewCAm7D0fYyziIjxCOYQZPaxajMqujsvQqCwnbj8dB5k83TCtTURESNheQdTgOCz0EsxiUqbNBSGg+fUzqx8dqc1dVUreKU8qtKUVI+HNAQjSOCp4+mkwpN3VQ5g6FkPAYkHGMh4A0E0LyTVCEpPSAhPs7jqt0LtkKCkJiCVNEUC7dti8kuQdkvYl65GhsVdiUvXKTm5DkGJFwCfdz5SrMroSIXNcxuXEohCSXZcxJZR+kK2GZ89VyR0hSjsh6GTN0NDp3EycUyx0hMYVgOhGSMiJyECNiCumvMJl8cxiEpI8BCeEIm6ku6aYhXCo+t9QRkr4tZU6r7r9AiGZCRM4sdYSkDxEZx4hYyqTrwqeLhaTLiIRlzIkjkYVpHZMLh0FIdh2REBD7IXmZxenEvomQbD0gNlXzFvZLzsRESLYdkS+VTdUSYnLuC5SERERoyxUdIRERxERIRAQxERIRQUzKsucQiAgvCufC3/GcQEga+SwiPBHOhS9iIiRNphE3m/FcTE4dBiF5TUT8LAR/Mo5vNAjJsxEJH8BzkvCSw/iGg5D8FpGRsZUGTuIbD0LyMyLDylcB0NypzVchecoVGt5iaIoVkvU");
            WriteLiteral(@"0Er5j1XqXtwqbr5+EpOyIrL/tHdo4Kn2/pPSJxLe9s7FzqeT9kmJDEn+8yq47m7L+YXghKWxJ44e82bRJqUucUicSSxoscYSk1TRyYEnDlpc4EyHJOyLrL26GbTqKy2chyXUNG98xYBfLZyHJcBqxwcoujUvaeC1pIhERdu1YSPKaRsLnaNwGz67tl/J1A6VMJMfOaUzCQtJmGgnrVJd76cqohKmkhInEkgZTiZC0mkZGQoKpREi8E2AyFpJOp5GhaYQeyfq+kpwnkolzF1OJkLT10XlL30KS6yeDswxJ/ISvz9RgKhGSVg6cr/TUX0KSxjRik5U+G8WPbAiJaQQsb4QEnKNC8sKyRkiwvBESpcfyRkiEBIo7V3MLia8LIKXlTTb3OmUTkvg5Br9Vg6lESFr54LzEBC0kXhSEREi8KNDQMJfLwFmEpNQfbsaSXEi8GBCYSLwY0Np7IREScO5mFBJfYkSyctjj2/MigDdCE4lpBOewkHgRIP19khxC8s55SOKS/4yYiQS6Z7PVRAKYSKAHUv/MzZ6XEHoh6X2SpEOS4++DgJCoOBS5RLe0ASEREkBIACEBEBJASAAhAYQEQEgAIQGEBHi0EhIHH9q6E5KODAaDhfMPhASwtPECgOk6j5BY3oCQmEgoXvJvhiYS8GYoJLWl85DEzYVESMBEYmkDnbtL/QkkH5LBYLAyleDNUEi8EJRsGd8MhURIoOxzN5eQfHc+kqh5Dk/CRALdusvhSWQRkrjGFBNSPHdNJJY3YFmTW0jmzksSMxMSIQFTdG4hifskYkIqljl9w19u35A2c35ighYSIaEUWZ2rWYWkHhXDZ25cBqbvVvW5KiQ9N3WeYhoREi8SQiIkvVjeuHpDXy1zW9bkOpFY3mAaEZKNTCUhJL5dnj66FRJTCbQxj0tvIVF+eLObXJ9YtiGJ5XcFh77IcpO1hIkk63cAknOd85PLOiTxS2NcCqZrq3gBQEgS9s15TMey36/LPiSmErqeRkpYYu8V8mKaSuhsGsn");
            WriteLiteral(@"hd2uExFRCd8KVmiLexPYKelFNJezadSlPtJiQxKnE3a7syiL3KzWlTiTrdwifwWEXLkt6skWFJN7t6tZ5tm2ayw9fCcnzMQl7Jb6OkW0JE+9VaU96r9AX+9L5zpZclXC5V0iqnxuvPofDps1L2mA1kTwIG69L5z4bXNJclPrkiw1JHD/Pnf9syEWuX1okJC/HZFEVdNMQWzPL+btGhOR1MQlXcdw+z1stS17SCMmvzis3qtHcj+VxiVdphOT/p5JwIpw5EjR0FZfHxROSx5gsjKg0MC31Uq+QvByTcGI4OXhJuF/Em46Q/DEm4QSx+cpzwuTqtgEheZXzyudx+J3NVSFpNJWsN1/FhKcROSv5pjMheXtMvlYuC/MYEW8sQvKmmCziZCImZRMRIRETWrkQkVf8f+IQvM79/f1+/edL/Rg6GsUsZ85L+6YzIdldTE7rx8jRyD4iljNCstWYDONksu9oiAhC0jYmYTIZOxpZWcTljEu8QrLToJzUfw4diSzMKzebCUmHMZnUfz47Ekmb+uyMkPQhJuO41HFFJy0/fjrCp3iFpE8xsQmblmVcythUFZJeBuVT/efIkei18P2qF/ZDhCSFpU7YiHW/iaWMkNB6qRMmk4mj0QvzqvCfjBAS0wmmECERkx/TyaSyd7Jr06rQ3+IVkryDMorTiTtitytcibn0gTshKWG5c1y5VLxpYf/j2jJGSEoLymFc7tg/aScsXW7jryYiJILiaDQPSP24sQ8iJPwalPCwh/KKJUz18OPdAiIkPBOUcQyKTxb/ah6nj5lDISS8PijDGJO/Cl72hOkjhOPWzWRCQvuo7MeoHBQQlVWMx8z0ISSIingICYlEZRSDMo6PlL4TZR4f//g4v5DQv2nlQ/Vws9v7qj83vYX9jUUMx527ToWE9OIyjkugUfV4aXlbl5gXcZkyj3/vwj9zmVZIyH+CWS+H3jdYGq0j8XAimTAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            WriteLiteral("AAAAAAAAAAAAAAHL0rwADANq3ok68n5URAAAAAElFTkSuQmCC\"");
            BeginWriteAttribute("alt", "\r\n                    alt=\"", 7503, "\"", 7571, 1);
#line 169 "WelcomePage.cshtml"
WriteAttributeValue("", 7530, Resources.WelcomePageImageText_LightBulb, 7530, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 7572, "\"", 7621, 1);
#line 169 "WelcomePage.cshtml"
WriteAttributeValue("", 7580, Resources.WelcomePageImageText_LightBulb, 7580, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(@" width=""274"" height=""274"" /></div>
            <div class=""browser"" style=""opacity: 1; visible: true;"">
                <img src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAYAAAAExCAYAAAB1UXVvAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAGcxJREFUeNrsnUuPHcd5hqvJIU0bkcJQgkXGMOgYshHJsM0MhMBwEFlxsjDsjQBvsrQRL7LzT0j0C5xFFgogAzSQRTYGnEUCb+IwCWIohkFScSwnsayQkiwOb8O5cc45fS6d/nou6jOnL1Xd1dWXeh7iiNTMmZ4zfaa+t7737aoOVAZ/9q0/Px//9VL8uBI/vnT44ZcUAAB0nVupxxvx49p3X3v1ZtYTg4zC/5348XL8OM95BAAYBCIAr8RC8INMAYiLv8z2/5nCDwAwWK7GIvDNo/85nZr536D4AwAMmivr6y8EN67/9Jr8z6nDD36H4g8A4AV/EU/6P5EIwOHs/xucEwAAb/j2UQfwEucCAMArkrq/pg4u9WyMvQ//lrpz4XeO/z7Jhd076onRI3Vx8//UUzt3eFsAAJrnirg/IgBfsn3k8Mw59cuPrSePh09cKnxuWhTOzsbq8t031fpbP1K/EYsCAAA0JwIiANbCXyn8P7/8B+q/PvFFFa6dM//6tQ+E41LcEbz4s+8jBAAAzXD+9Pr6C6/aONLtZ55X//j731LvPf0pNT+1Vvt4Yhn9PBaSIP4jYgAAAFb5nzUbR3n9ua/FM/8vNvIKrz/75cQm+pMbf6vOTse8ZQAAljhV9wD/+tmvN1b8jxABkO5CLCYAAOiAAEjxF7/eBRImIwIAAB0QgBvP/rGz4n9SBAAAoCUBEEtGvPk2EBEQ8QEAgBYEQKyfNhHxefjkJd49AIAaGF8FJLNvuUSzbf7jd7+mvvqT17");
            WriteLiteral(@"Se+/nPf453GgC84Y03/rMZAZBFXlW4cv60evm3z658/Afvh+rm1tz4eGJDyYM1AgAA1TCygCT0rbLC9wsX1qwW//TrAQAABwJw+5nnjL+BFP6vXDxjvfgfvJ7neQcBAJwIwEfNCq4Uf7F+mij+gnQjWTuMAgCARQEwLbRZxX88j9Srb0+sFP8jNi58kncRAKBJATC58iev+F+9HaqN8cLqD/DwyYu8iwAAFdC+CkhHAM6dDtQ3Lp9VF8+t6orU/awsQIertya5nwvXPsy7CADQpADUKf7C+TNB8gAAgG5wytaBvvLMmdzi3ySEwAAALQvAD+9O1X/vzp3/ACwEAwCohjULSELev3s3zL30c2saJQ8AAOiZAOjem1eu8VdqVQTEHXr94cx6l3B2NuJdBACogLYFdGH3jvZBsxZ6SUj8px/P7g7q8NTOBu8iAECTAvDUzp14tq1/T14Rgdc3Zysfz7OIqnJx823eRQCAJgVAuHz3TaOD/3BjemgJNSMCIkiEwAAALgTg3i+Mv4FYQXkiILuE1sFUkAAA4AOMKrAUXAmDTW8Ic5AHhCtbQsvK4PNng6RTqML6Wz/Sep7uzREAABCAkqJb5ZaQIgI3t+xdsfOpX1/XvjIJAABWMV4IJoX3KYMrgppAvH/d2T8AAFgSAOEPf/b9Vl/0+lv/xOwfAKANAZBLQl9sSQQu33tTfebWj3nnAADaEABBrCB5uESspxdb7j4AALwXAEGKsSsRkOL/1Z+8ps5Ox7xrAABtC8CRCDQ9KxeRofgDANjFym6gUqBlr6B/++zX1cMnLll7cXK1zxd+8Q/OrSYAAATAAAmGX/73v1a//Ni6uv7sl40Xi53kM7d/nFztw6wfAKDjApDuBuQhQnD7mefU7Y8+ry8icRdx9PUUfgCAngnASSEQ5LaNGxc+efzvI8Q2+lBc6OXvS5tvU/QBAIYgAGlkx86jXTt/j3MOANAJTnEKAAAQAAAAQAAAAAABAAAABAAAAIaD1lVAp55dV+O1c4f/F8");
            WriteLiteral(@"R/UgQ6RwhWnxaUfYXSfkKg8dWB5jcJ9H4gAKjJaDZX79x9yIlogI/vvqM+Mtu3IwB3PnJJbX3o/ErhLCuVQXGlNTyGqQisfjQoOY5u6UciAOoxjyL1vw8eq/D805yMBnh69MCeAKwQpf4K8gtilPpXcLJ0Gh8j4zmpT0aZYhAtfST3WFHRMQxfEwCU8u72SIXzBSeiZeovBItSBbG0kEepohlUPEYVMVj9yqhACBADgOa4uzdR2+MZJ6IvAhAlfzQKXfTBjL7oedFSV9CuGJR1BYgBgD32wrnaiAUAetwBlBa6E/ZO3vNWLaIcMdASlOLXIp9cfV51MQg0zxFCAHCA+P63tvY5EX0XAKNCR15AVwAQ86vNfTVfRJyI3gmAzMSjQ/8+CKoXOvICxAC85P3dsRpN55yIPgpAunAdCYE1MbCRF9iwiFSWvUNeAFCXzdFU3X8cciJ62wGo7LbNihjYyAuMj1HyWgotInMxIC8AX5HFXjL7h14LwEGRKpzRGogBeQFdAQwfCX3f3R7j+w9BAExmquQFWEQA7+/g+w9KAEyLE3kBYgB+cn8/TLx/GIAAJHU8pzI6FYPKeUFQ4xh18gI9iyh7jUK9LgygLRLffwfff1AdQJT6R6DciYGdvCDfItI/Rs7rqWgRLR2LrgAGQrLY69GIEzE0ASgUg6D6TJW8AIsIhoMUfzZ5G5gARGWfi1LFp02LKF3IyQsQA3CKbPK2F7LJ2yA7gLLLQNNi0D+LKC0G5AUApmxPZmzyNlwBOEiBU2VZbxbqQAxcWkRmgoJFBH4glo/s7w9DFYDoZAsQ5ZXJcjEgLzAWAywi6DK3tkYs9hqyABzX/5XqUVgms4sPeUHhiyUvgD4hM38Wew29A8gqGCViQF5AXgDDRhZ6sdjLkw5ASwxWLKJyMSAvyHk95AXQYdjkzbMOoGiGGOV2BWkxIC8gL4AhcLTYC9/fIwHQKQomFpFW8SEvKHyx5AXQBuL7s9jLJwHI2QvIlhiQF5AXQD+QTd62xyz28k");
            WriteLiteral(@"oAIo2qpGURZT6xRl4QVJ+pkhfQFYAZeyGbvPnZASwV6YxNzKx0BenvU98iMpmpWs0LbFhEjsQAiwh0SXz/rX1OhJ8CkG1qrMzqrYlBj/MCG7e4NBYUt3kBFpF/EPp6LABRh8SAvKD9vICuwC/kck82efO8A8gfzNHKLDIo+SLyAvIC6Aeyydv9xyEnwmsBiHQGc4mpQV5Q0d4hL4B2kMVebPKGAFSYzZMXGNky2vaOg7wg83JQ8gLfkND33e0xvj8CkLkZqEEBJy/QKnRdyQtKZ/TkBT4gl3uyyRsCUDxIjQs4eQF5AWLQddjkDQHQFoNqBZy8wFgMyAsQAwfg+yMA5RZQ2QDN+GAXLSJdMXBpEeUei7yAvKBhjjZ5AwQgUwEizaJRfTbfzbzA5ZbVWoWugbzAflew+pOQF3QbNnlDADQqjt5AJS+oLwZD3bI6973CImqNu3sTNnlDAJTeUEuNThMxIC8oFwPyAsTANbLJ20YsAIAAFDlA2YPYQAyGahGlxYC8IP+T5AXdQywfNnlDAIz7gECzM2jeInIjBl28xaVWoSMvoCso4NYWm7whABUo3g4iIC9Q5AU2LKLc9wqLqDayyRuLvRCA8mIf5V8GWjxkFXnBCYvo+HnkBcZiQF5gD1noxSZvoH8VUOXBTl6QJwbkBfmfJC9oDlnsJbN/gGoWUOXB3p28wIZFtCQGNiwiR2JAXuBvV8Amb1BfACrPHruTFxRaRKkPlhWFSMsiqiAGFvICKxaRViEnL+gLstgL3x+MBcD+7JG8oMwiOn5exbzAikVk3PGRF3SV+/shi73AXACiRmeP9cWAvMCRGJAX9DYvSHz/HXx/qNIBRAfz1yC3bNqaPZbkBUH5ACQvsCsG5AX97wrE9//VJou9oLIFFB2LwMFArXAduo28oKJFVFcM3OYFgX7xiTp2SalWIScvcI3s8EnoCzUEYLUb+GCgBg5mjz7lBT2+xaVxx+fAIsq0d/zJC2STt70Q3x9qCEBUJgZBtolBXmBXDLzLC2");
            WriteLiteral(@"zc4rLU3hluXrA9mbHJG9jpAHRab2tiQF5AXpBz4sgL9JBN3rizF9i3gAzFgLzA3CJa+hLyAvICQ5I7e7HJG1izgKLqYkBe4M4i0io+5AWFL3YIeYFc7sliL7BrAckMMtDrDILcwU5e4EoM/MgLAktdo669Y2YR6diQpl1YGbLJmzwArFtA6U6gSAzIC/TEgLygbseXbxFV6xrrW0R576uLroBN3qBRAWhaDNxaRNnTPfICRV5gSQxcWkSJ78/1/tCEAESHf/LmkrbEoCgv6KJFlDnYyQvsW0TGHZ9/eYFc8SNX/gA0ZwFpGAtH4528QJEXtG4RZRpug8sL2OQNmhWAKF8Mmu4K0hZRbTEgL+hNXuDSIjITlG5ZRI9DNnkDFx1Azj0hTboCm2JAXqDICxoQgz5tWX1wvT+bvEHDAhCdtAGC+haRrhgUWkTHA5W8oEmLSEsMyAsKX2wTecHbm/uEvuCoA9Ac7FXEoHJXkBYD8gLygtodX3/yAhZ7QSsCYDLYV40F8oKmLKLM8kVeYN0iMhOUZvKCnfFMPdgPqV7gyAKKNItGiRiQF7gRA/ICN2LQRl4wns3Ve2zyBq1aQDpFLHJjEZW+JvICpxaRlhiQFxS+2Ly8YB7/9d72OAl/AVq1gHQGl628wEpXkBaDrlhEqnxvefICu2LQ57xgY3ecdAAAbi2gkt9aEzEYTF5gY8vq1Ch3aRFllq8aeUGQ07JUzguCirN5Ndy84MEoVI/Y5A1a6QCi6HA4B8szvwoDlbwgRwx6nBcUdwXLsl7XItJ6P06IQWcsoopiMJ4t4tk/d/aC1i2gEy1+yQgiLyAvKLKI6opB725xaSwoSi3i1/4OoS+0bQFFGYVjqSxbsoiKZn46YkBeUGc2T17QTMdXPS+QTd6mbPIGXegAigrH0qyOvKDm7DFnkZDBvWjt5QVBzQ4j43PkBUonL7j/OEz2+gHoiAWkZydkigF5QcXZoz2LqJoYlJga5AUVO75ii2h/Oo8FAN8fuiAAUf5IKg8Zyy");
            WriteLiteral(@"0inYFKXmBXDMgL6ltE9jq+5bMplg+LvaAzArBU/yvZO+QFdmeP5AWlwt3jvOC9nRGLvaCbFlB5C68rBsPPC4osInuzR/KC0veqR3nBnd1JctknQCcFQH+g6tkJQ84LiiyiZmaPHbaIjDsM//ICuavX9pjFXtA5Cygy30HSsCtYavHJCyrNHm2KQaFFlPpgFy0iXTFwaRGVdXwy67+7R+gLPbGAtAoQeUG+GJAXtJ4XuNyyumjsyGKvO3vj5G+A7glAtFoBtYvvyYFqZO+QF+jMHskL+p0XiO8/wfeH7lpAJ1YC1xCDavYOeQF5wTDzgs3RVO2FMyoRdN8Cyh5Xyya5dvFV5AVe5AVcUprbFYxY7AX9EIBIwwpYnQqTF5AX2NiyukkxaOsWl+L3/3pnTAWC/nQA2jNa8gLrFtHx9yIvqGA3ZXyu5bzg/d0JoS/0RwB0PM9Ci6iCGNjIC6qtUWjWIqorBuQFdeym9vMC2eRN7B+AfghAKgXWbnOLxMBhXtBFiyjjVFQTXpsWkSMx8D0vkN09t1jsBX0SgChnoFYWA/KCRi2i2mLQ47zAhkW09DtmwyI6PM5sEbHYCwZgARWsCA1MjlPTIsoeqCZiQF4wtLyg0CIymLxEWhaRvhgs4uJ/Z4fFXtBTAdAdqC4tovKBWjbzIy8gL3CTFzzYD9WEO3tBPwUgqjRQm7CIjNr3AVhEGbqo311liQF5gfO8YHcySx4AvRSASHuY5Q9U8oL6YjDYvCAwfE9rWERpMXCRF4TzSN1jsRf0ugOIDovP8Xg1EAPygkwxIC9If7HLW1ympzTN5gXi92/sstgLBtEB5A32/KpKXkBe0KRFlD1JMJnNN5sX3N8Lkyt/APrdAagTm8FlDvbiqtpGXuCbRZShi/rdVZYYkBdUzgsejafqMYu9YCgCUPgLvzLYu5EXVLaIeiQGLi2i2mLgSV4gN3d5NGKxFwxMAIzEgLzASV7g0iJKiwF5QfYvp9zMncVeMCgBiDQ/H5QOdvIC8oLs349e5w");
            WriteLiteral(@"Wp42ywyRsMrgNIXQVkXHwzBzt5gSuLSEcMyAuUlbzg0ShUIYu9YLAWkOZA1bKINMRguHnB8C8prS0GPcsL9sK52mGxFwxTAFZuCqk9ULXEwLu8oOAWlxXEoIu3uEyLgVuLKP3FbvICmfUT+sJgBSBSJ6OwwHigFg588gJv84IuWkTZk4TsFyqh78P9Kb4/eGABZc9drVtEy4JCXlDXIjp+DnmBsRiU2ZAy88f3B28EIEsMgpw+mbzAhhiQF3Q1L9gdz5IbvAAM2wKK9GZ9pWJAXqCVFwRlPVelNQo5FlHuccgLir5n4vtzZy/wpQMwH+zkBYU/U8WuIC0G1TKHAjFwmBcUWkTHvx/dtIjE77/3OKR6gJ8WkNlgJy9o1iIqF4Mu5gU6q4a7mhfIzV0IfcEfC0hDDPTCQQcWkYYYkBfoiQF5waoYyLX+kxmhL/hmAZUMsuoW0WrVJS9QFS8HJS9oMi8YzWSxF74/+G4BlRUx8oKMDsMsL7DRFaTFoIt5gZVLSo9/P5q1iOaLiMVegAAY2wnkBYUWkVHxVdzisvG8IKfzfDhisRcgAFbEgLyAvMCFRVRJDDK6xq24+E9Z7AUIgB0xaMIiqi0G5AXkBRlP2J/OkwcAAlBDDJq2iJbtnQqvibyAvODE108XETt8AgLg2iKqKwbkBTYsonIxGHJeIN9vc8T1/oAAtCoG5AXkBS4sopPfb2s8Ta78AUAAemMRpcWAvCD3GOQFhWKwH87VeIbvDwhAJ7uCuhbRsr1TQaAyj1GeF1i3iDJaJfKCenlBOFvg+wMC4IsYdGbL6rpiQF5QuysQx2eLHT4BAeinGJAXkBfUEQMp/tj+gAB0XAzICwzOEXmB1u/H7mTGnb0AAeiTENgTA/ICn/MC2d2TxV6AACAGqhd5gWWLyKj4qmHlBdN5pLbZ4RMQgP7jTV5QYBHVFYMmbnGZLwbt5gXyo8v2zqz1AgRgYJAXOM4LKtk77eYFu+FMzUh9AQEYLuQFFYVp4HnBeLZIHgAIgCc4t4");
            WriteLiteral(@"g0xIC8IPsnajIvmMU/0y6LvQD8EgAjO8HGLS7Thdxzi2hJDFrMC8Tx2RlT/AG8FgAjO6EreUHhltXmYmDFIqogBjbygmprFOLiH87UnNQXAAEw7QrMxYC8oKm8oIpFNJrOubMXAAJgVwzIC7qfF8jNXVjsBYAAWBcD8oJu5wWLJPRlsRcAAmBJDMgLTF6LmUW0dJ4t5AVyvT+2PwAC4KwrMBcDD/KCAosot7vK6goynpz3qf0pi70AEICOiAF5gbu8QHb3ZLEXAALQGTEgL3CTF8wJfQEQgC6Igcu8wIZFtCwGgcZsfvkDbecF8tfjuPjj+wMgAJ3vCszFoNktq5cFpfjVt5EXlAmBFP85vj8AAtBnMSAvMN+yejJfsNgLAAHovxiQF5jlBXK9/wjfHwAB6KsYkBcYCFOqVZJ/7oVs8gaAAAy4KzAXAz/ygn1CXwAEwFcx8DkvEN+fxV4ACIC3YuBrXiCFf8JiLwAEwDcx8D0vkEk/oS8AAkBXYEUM+pMXyJw/8f35NQBAABADfTEYQl4gts+C1BcAAQAzMeh7XiC+/3SB7w+AAICWGAwlL5BZ/2SG7w+AAIC1rsBcDNznBfJf2d4Z4wcAAQAHYmAlL7BhEamD6/3x/QEQAHAkBlbyAgu3uJSburPYCwABgIbFoGt5gcz6Q3b4BEAAoP2uwFwMqucFyVYPrPQFQACg22LQRF4wIfQFQACg+2Jg2yKSa/0JfQEQAOioGDRlEc0jQl8ABAB63RVUEQN5Prd1BEAAYKBiUCQEYv0w9wdAAKDnYmDaFcj1/jg/AAgAeNYViO8/p/oDIADglxiICBD6AiAA4JkYCGzvDOCeU5wCaBuZ+TP3B0AAwDPE92exFwACAJ6xIPQFQADAP6TsE/oCIADgITNCXwAEAHws/pHC9gdAAMAzFoS+AAgA+AeLvQAQAPCUWYTvD4AAgH/FH98fAAEA/2CxFwACAB4idZ/FXgAIAHgIm7wBIADgIVzxA4AAgIfMF/j+AAgAeEeyyRvFHw");
            WriteLiteral(@"ABAL9gkzcABAA8hU3eABAA8LL4s9gLAAEA72CTNwAEADyETd4AEADwFHx/AAQAvCz+kWLuD4AAgGewyRsAAgAewiZvAAgA+Fj8FZu8ASAA4CWEvgAIAHjInMVeAAgA+AebvAEgAOAhLPYCQADAU2YRvj8AAgD+FX98fwAEAPyDxV4ACAB4CIu9ABAA8BQWewEgAOAhXPEDgACAh+D7AyAA4CHJYi9m/wAIAPiFlH2sHwAEADyETd4AEADwsviz2AsAAQDvWBD6AiAA4B9s8gaAAICn4PsDIADgZfGPFHN/AAQAPIPFXgCAAHgIm7wBAALgKWzyBgAIAMUfABAA8IE5i70AAAHwj2STN6o/ACAAfsFiLwBAADxlFuH7AwAC4F/xx/cHAATAP9jkDQAQAA/B9wcABMBT2OQNABAAL4s/m7wBAALgHWzyBgAIgIewyRsAIAA+Fn/FPj8AgAB4CaEvACAAHsImbwCAAHgIm7wBAALgISz2AgAEwFPY5A0AEAAfiz++PwAgAP7BYi8AQAA8hMVeAIAAeAqLvQAAAfAQrvgBAATAQ8T2wfcHAATAM1jsBQAIgIdI2cf6AQAEwEPY5A0AEAAviz+LvQAAAfCOBYu9AKBh1nSe9Ol7b6jZqTOcLQCAHvBkuG1PAH5T82AAANAfsIAAADwWgGucBgAA77hJBwAA4CdbIgD/wnkAAPCL77726jURgJucCgAAr0jq/lEGsMX5AADwhr9PBCBuA6T4X+V8AAB4w9WjDkB4hS4AAMALXokn/reOBeCwC/ij+HGLcwMAMFj+Kq73f3n0P6eP/nHj+k831tdf+F78z0n8uBI/znGuAAAGwbX48c24+P9N+oP/L8AAx5G6SMzC+fMAAAAASUVORK5CYII=""");
            BeginWriteAttribute("alt", "\r\n                     alt=\"", 16709, "\"", 16776, 1);
#line 172 "WelcomePage.cshtml"
WriteAttributeValue("", 16737, Resources.WelcomePageImageText_Browser, 16737, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 16777, "\"", 16824, 1);
#line 172 "WelcomePage.cshtml"
WriteAttributeValue("", 16785, Resources.WelcomePageImageText_Browser, 16785, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(@" width=""384"" height=""305"" /><div>:-)</div>
            </div>
            <div class=""light second"">
                <img src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAARIAAAESCAYAAAAxN1ojAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAEf1JREFUeNrsne1LHFkWh2+3otGxscGQTHSCMkLCZtj9MB/2//+8HxZ2QjJEcDE4ZlaJ0KFNxzQ22TrmVKY1/VbVt6ruPfd5oOjJQKL10k/9zrm3brUcmOHLly9r2cd6tnWybSXbNvRzM5BfcZhtn7PtU7aNsq0vn61Wa8DZi5sWhyBaaWyqKPLPTuS71FfRiFQ+ZXLpc5YRCfiVxoqKomNEGosiUrnSz34mlyFXAyKBcuLYCqg0CaE06ucbYkEkMLlUEWl0E0ocvhLLJX0WRJK6PHZUHmsckaWQ5m1PtkwqPQ4HIkEegFQQCUyQhwjjoQoEedQvlUvKH0QSs0B2VB70PMJARHKhSWXE4UAkoaePxyqQFY5I0KXPBSkFkYQmEEkdj9zX3gfEQ1/LnksOBSJpunwRgTDXI25kTso7yh5E0oRAdh3NU4tlj/RRzhEKIkEggFAQCQIBhIJIbAlEmqdPEQhCybZTmrKIpKhAZBTmiWMOCNxFmrInLHOASOYJZEUTyA5HA2bQV6HwBDIi+U4i0gORoVwmksGiSP/kXer9E0TyVxnzk2MuCJQvd05TfkAwaZFoGZOnEIBl6alQkit3khUJozFQESMtdS4Qif0UQjMVqiapZmxSItFeyAEpBGpMJ0nMPUlGJJlEJIXQC4Em6Gk6MTuyY14kuj7IoWNEBppFSpxjq+ufmBaJNlSllGFeCITCqcVGrFmRUMoApQ4iWUYgkj6eUcoApQ4iKSuRTZUIpQzEgJlRHTMi0fVCDrg2IUL+");
            WriteLiteral(@"zGTyDpE0LxH6IRA7l5pOouybRC0SZqmCMaRfchSjTKIVCU1VMEqUTdgoRcIkMzDOSJNJNDKJTiSMzEBCMjmOZUnHqESCRCBBTmIYHo5GJEgEkAkiQSIAhmUSvEiQCED4MglaJEgEIA6ZBCsSJAIQj0zaSAQgOg502VBEMkMiK0gEYC6HesNFJEgEoDS335VQZBKMSHh2BqCUTA71u9MowTRbs4Nx4HiKt2m2sm214N+5ybYrDl2jNP7UcBAiYT2R2pDFsNez7cHYlv/ZByKVj2Nyuc62z/rfNxz+SullIjlOViSsbFapNLY1ZazrZ5Ncq2REKh+QSyVcZDI5TU4k2ij6G+ffqzjyzxjIpdLTT8SyPI3MMWlMJNog+rtjhKYs0suQNPdQxbFqYJ8uVSqXmmCgHL/XvZZJkyKRJMIITXl5WG9MS1o5RyqlkFXWXtfZfG1EJDRXC5PL43Gi+y8yea9igcXoZyI5MisSfY3mIed5ofSxp/J4wOG45UZlckZKWYjaXnNRq0h0rdUXjr7ILEQa+wmnjyIpRYTS41DM5KiO5RrrFgl9kel0VR4IpBgy2vMWoUxF+iQvq+6X1CYS+iJT2dJSb5tDgVAqovJ+SS0i0Ueen3E+KWFqEorM8GTa/l3kLX4X0YpE54tIX2SNc3lL3kTd51BUyrkKhUluf5U4MiQ8jFUkB46H8XJ2tIxhFKYebrTcOeNQ3DLIRPJ7dCJhqPdOGfPc0QdpCilzjih3bqlkSLgykVDSfCMvY1a5hhvnTBNK6uXOS98lTpUiSX2UhhRCOgkV76M4lYiEUZrbXshzUkjQvNUtVbyO4lQlklQnnok4pCfEkG4cyFDxq0RLHa8T1byv2ZpJ5FGiEpFS5h9IJCqk7Pyna37RpyaQHuZTX/+YV5Fog3U3wZMio1O/JnpBWkiRvyZ6A9jx9X4c34nkqUvvgbzHmkToh8TNc91S40lQIlGz7XDxQeQ3hV8Suyl0dN3kYBLJk4QO/qoKhH6IwbifYMLcXfbdOF5E");
            WriteLiteral(@"ojNYO4kc9FVHU9U6W3qOU3mUYW3Z69lXInmayAHPJUJTNQ2ZpNRAf7RMKllaJFpfpTANHomkR0rnfGWZVOIjkexyQQHn3gRPdDnUekWSSBpBIpDSNVAqGLSb+KFcQBDptfDM2R/N2SmTSkqLJJE0cohEYIx8NMe6TAoHhHadPywymCcC02Tyi/F97BYdwSklkgTSCK+FgFlsO9szmguP4JRNJJYXLOo6pr0DN5tC80oKi0SfqbG6TIDMZHzBdwQKlL9dw6lk4X0rk0isppFVlQhP8UIRLF8zC/dBC4lEh4WsGpgRGih7A7LafF3T5+i8JxKrNeGOo7kK5ZHm677h74Z3kVhcbyRf7R1gGfaNpvXuIhPUFhaJDvlaXP2M1d7BF1Znvj70mUgsppE9x3tnwG+6tVjizP3uLyQSjTYdTjrAQjcnayXO3KbroonkocETTkkDlDieUknbxz8S6UGhpIEq0+6esX2a+fzNXJFkf1lmsVp6riZ/Gx5Alew7e2u+dpdJJNbSyJ5LZ1FfaL58RiTz/nKkkZMGK9TFtrHvz9Typp1YWYNEoG5+TiGVzEsklsoaeY6GafDAddeASCzFMhqsQBKuqLxpJ1LWdB3DvdAcD6ynkvacSGYFShoglfijU0QkVsoaa3cD4DqMI5FoDWTl2RpGaiAUfjSyHyva+pibSKxIZJU0AgFhaV5JNyWR7HHtQmBYubFtLSKSLU4aQGXXpIUngzszRaL9EQuvm5DJdDxTA9zgKkJfTTM1kVgpax5yvQIldz2pxKpIaLJCyDww0j7YmiWSDSNlDQDlTbVsWk8klDXAza56vs0nuSOS+5NMIi5rSCRAeVMPG5MSCWUNAOVN4fKmPa3moawB4KaXciJhuQCIqbyJfa5TZ5JIYm+0yvx/3lUDpJIakRfotcf/QBoBaOTmFzvr44lknZMCwM2vTHnTNlTWkEggRqQUj30YeGVcJCukEQBugCXYGBfJBicDoBFiTyTrlhLJFtcjRMoPkf/+a+Mi2eRkAHAT");
            WriteLiteral(@"LMOtSKa9zzMyWMQIYibqHl/bSBqh0QqxE/X0izYnAYBE7UskG5wEgEaJuk+SiyT251MQCcRO1N9BK6UNIoHYiXoelJXShh4JQAAiiX34l0QCFoi2T9Lm3AEEQ7R9EgsiYWo8ACJJ1+IA94i212dlZiuABaLt9VlptgIApQ0AIBIAQCQAAIgEABAJACASAEAkAACIBAACEUmfQwHQODckEg4+wLJ8RCTNccX1B4BIAMBIaTPiBACQrpcVySdqSwBIvbQhkQBpBJGkfRIAXOTtBSvzSK65DiFyeiSS5vnMdQiU582LZEBpA9AoUQ8Y3Iqk1WpZGP6lvAFuhgGUNkOMDtAI11ZKGyH2PgPlDXATbIbRuEhin5T2gesRIqUX+e8/GBdJ7H0SEgmQSJphOC6S2OeS3CATIJE0L5KRgRNCeQNcs02WNq1Wa2Bgh3pclxAZ7w3sw/D+zNbYyxsSCXDN1oyEkPsiiX0uyQ0ygYiQ+SOx9/Vuw8d9kVgob95zfQJppL6yZpJIPhnYsUuuT+CmVxuD70SS1ToWXkthIS6CfW6M3PSuJiUSK+XNOdcpkJyrJx/tbU8zDCcJgLJmDt8qGKuJRMobRm8g5OvTTFkzTSRWXt/5P65XIDFXymCqSLKaR4ZzhgZ2UvokrC4PIXJmZD9mljaWUglNVwiND87Gan6D8ZUVrYvkjOsWAuMPI/txZ1DGukisNLWA6zE0enNFon2SgZEdJpVAKLy1siP3J6+2F40ukZuToWBoGmn8nxv6TrlFRWKpJHjLdQwk4wZEolNfR4Z2nFQCTaYRSyLpF0kkE81DKgEolUaszGkaaA81WZGQSqAJro3dxCa2PGaKJDNPz1B5QyoBrjk/N+RiIjGaSpjtCnVxZex6m1jWpCiS/A7BMzhQB/81tj9TR3LnisRgeSM1K5PUoGrODd6Ee6VFMs9EEacSlmOEqpDEe2xsn/rTypqURWIxdkI4HBssn2c6YCGR6OS0gbED06PEgQr44Ow19EfzyrR2gX/swuBJ");
            WriteLiteral(@"lxLnmmsfPJY0bwzuV2987ZFlRWKt6Zqf+Ndc/+CJN0ZvTHNDxMIiUSNZfEn3lWOiGvjpIVjsJQ7yV074SiRWy5u8xGH6PJTl2mhJs/B3vpBI1Ex9owfslWOiGpQvjy1eO6PsO79QymqX+McvDV8Qv/G9gIIcO7tzkhauQAqLRA01NHrgrgxHVPDPubP97NbC+9Yu+QPecXFA4nwwftO5nDfk60MkFoeCx3njaL7C7OT6yvg+FgoLpUSiprowfiBfOZ7Hge+x3FwdTyOF2hftJX7YufFUkjdfkQncvyasz4Yu3LooLZJEUolcOEeOYWFI58ZSOI0sm0hSSCV5PfwbMkmeVNJpqYGUpUSSSCpBJvAmEYmUSiM+EkkqqQSZpF3OpDIdoPS0jqVFoqnkNJEDncuEpQfSkUgvkf0tnUZ8JRLrs10nyeTfjtGcFCSSyjleOgy0Pf4ypwleaExa40ZhgYsis1grFYmuNt9P6OCLTP7jmE5viQ8Jlq7D7Lu79CMvbc+/1EmCF5909I/5DkbPud4YUmume6kkvIpEmzUXCV6EZ44RnZiT5RuX5lPffa0kwhKJIjFplOBJkRPyL0cTNiauXVrDu5VVEK0qfrsvX750s4/DhC/Qfd0gXC41haSaIv/00RupVCQqk2fZRyfhC1VkKsfgAd/Z4EqZY5d2k1warC99/oNVimQt+3iRbSsJn7BVTSZ7fH+DIF+MKPUJhUeZSLyOsLaq/G0zmTzKPp5y/ZJOSCHBIHNGvM/5alX9W1Pi3Ekne47eSd2cO5vv4i1V0mTb62UnnzUlEkqcu0gqeZ5t2xyKSpHRM3lRfI9DUV1JU5tIVCY72ccB5/G7cufnbNviUHhF+h9vKWPqKWlqFYnK5FC/PHCXx1ru0D9ZDildzhyvX52EvHbz9yp/QJ0iWdESZ43zilAqEMiZow8yiZGWNIMqf0irzj3KZCJN12ec27lC+dHRQ1m0hLlEIDM5WfS1m9GIRGWym3084fzOpatSecyhuIPMBfnD2X11");
            WriteLiteral(@"rE9ksaKTOn5Qq4m9o19SiFWVyV7CZc+1iuPMMZlsUQZa0tTy3FtTIqFfUo4tlcpOAlK5UXm8J30Uppa+SOMiUZlsuq/9EuaXIBXk4ZdjX8sDBC8SlQnzS/zwQIUi5eK2lkOxID2PnoqDJRiWx+tTvVGIRGUiz+I84vx7Tyvb+vmDC2fSm/Q3Pqo48k/wRy+TSCOr9bVC2PtMJgd6R4XqkLSyruklb3RXNcR8pXV6T8uVj/r/GKatjlqbq6GKRPok0i/Z5HpoLMHk5dAPBUqjXBLf7ogcykYQebxsSiLBiGRMJozkABSXSK0jNJNoh3I01KbHLs31XgHKcty0RIISicrkts5DJgALcVLVsgBRi2RMJrwnBmC+RIKZa9MO8QipZU+4VgAmchqSRIIVicrkEpkAfIc8iBfcS+haoR81Zr8C3JFIkDfXVgxHD5kAhCuRaESCTACJhCuRqESCTCBRTkPsiUQtEpVJV2XC8gNgnZPQRmfMiERlwlomgEQQCTIBmMLtoyKhzFg1LxKVCU8NgzWJHIXw7ExSIhmTyYFjMWmIm0bXE0leJGNCYaU1iBVZx+UkVomYEonKhOFhiI1G1lhFJPNlQhMWYmCkKcTEqnIti2dI+ybyEq4O1ysEiPRD3sbYVE1KJGNC4fWgEBoyN+Q05n5IciJRmXQ0nVDqQNOlzGlMk8wQCaUOUMogkgqFIsPDu6QTqJGLTCCn1neyldpZ1VGdfcdsWKiWoQtocWZEUp1QaMRCZSkk295Za6gikukykZdxHTh6J0AKQSQehELvBJbFxAxVRLK8TEQi8rwOLzOHIvQ1hQxTPgiI5HuhSJnzk6MZC/PLmFMrU9wRSXVC2dFyh5eawzjSQL1IuYxBJOXKncfu6/IE9E/A5PR2RFKvUHYd652kLJB3qfdBEIk/oaypUGjIIhBAJN6E0qXkQSCASHyUPPRQEAgi4RB4E0rXMcoTI7ejMNl2ThMVkYQkFRHKjmNV+9CRR/ovrK4PgkjsCGVNy54uKSWo9NFT");
            WriteLiteral(@"gQw4HIiElAJFkGnskjx6lC+IxIJQ8l5KF6nUUrrk8qB5ikiQCiAPRAJFpNJxzE0pSk+3PvJAJHBXLJsqlC3HokuTUseVpo4+hwORwOJi6ahQRCybiSWWvopjoKmDZikiAY+JZUOlsmEotYg0hnnqYIgWkUD9cpG5KusqlTXdQkwvIxXFcEwaQ6SBSCCOBLOiclnX/70xJpl1t/ykOZHC57E/X+nnTbZ9EoEgC4DE044mHoCJ/F+AAQAgl3zNeDGxuQAAAABJRU5ErkJggg==""");
            BeginWriteAttribute("alt", "\r\n                    alt=\"", 23246, "\"", 23314, 1);
#line 176 "WelcomePage.cshtml"
WriteAttributeValue("", 23273, Resources.WelcomePageImageText_LightBulb, 23273, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 23315, "\"", 23364, 1);
#line 176 "WelcomePage.cshtml"
WriteAttributeValue("", 23323, Resources.WelcomePageImageText_LightBulb, 23323, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(@" width=""274"" height=""274"" /></div>
            <div class=""bulb"">
                <img src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAVoAAAKSCAYAAACTAhMyAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyRpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMy1jMDExIDY2LjE0NTY2MSwgMjAxMi8wMi8wNi0xNDo1NjoyNyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENTNiAoTWFjaW50b3NoKSIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDo2OEMyQkI4M0Q4NzIxMUUyQTdDN0Y3QzMzMkU0QTgyQiIgeG1wTU06RG9jdW1lbnRJRD0ieG1wLmRpZDo2OEMyQkI4NEQ4NzIxMUUyQTdDN0Y3QzMzMkU0QTgyQiI+IDx4");
            WriteLiteral(@"bXBNTTpEZXJpdmVkRnJvbSBzdFJlZjppbnN0YW5jZUlEPSJ4bXAuaWlkOjY4QzJCQjgxRDg3MjExRTJBN0M3RjdDMzMyRTRBODJCIiBzdFJlZjpkb2N1bWVudElEPSJ4bXAuZGlkOjY4QzJCQjgyRDg3MjExRTJBN0M3RjdDMzMyRTRBODJCIi8+IDwvcmRmOkRlc2NyaXB0aW9uPiA8L3JkZjpSREY+IDwveDp4bXBtZXRhPiA8P3hwYWNrZXQgZW5kPSJyIj8+zKbSDwAAExlJREFUeNrs3b1uXFkBwPF7UbaABiNBB9qJQEABWruEJuMSsSxOgaBix0BBl+QJ4jyBsx0FaLxPYKdAovPkCexIFIhF8tADMd0WKJdz7Du7E68/Z+bcz99PupnsJvHHmev/nDlz5968KIoMgHS+ZAgAhBZAaAEQWgChBRBaAIQWQGgBhBYAoQUQWgCEFkBoAYQWAKEFEFoAoQVAaAGEFkBoARBaAKEFQGgBhBZAaAEQWgChBRBaAIQWQGgBEFoAoQUQWgCEFkBoAYQWAKEFEFoAoQVAaAGEFgChBRBaAKEFQGgBhBZAaAEQWgChBUBoAYQWoCvuxV/yPDcSQOsURTG8+P9CzyYN+xrLXwDaEdZB2B6H7ai4Xvzznfj3hRbgdrFaC9u4WMy4zuAKLdCGyG6F7XWxnPjvR0IL8MVI7RarNRZagHSRrSW2Qgs0NbKjIq1Rhd+L0AKNi+xgBWuyt1mzHVQV2nvuVqBhnoZtLfHniB8/LiFsXhHH4cX/t9TxuWa0QMNms1Van49r2PZvmAWPL4uwpQOgTaHdrTi04zLuh3f8dzHIa7f8nrL87BdvwQWaEdqTcDOo8FOezi0lLPJvN0M/j4UWaM2yQbg5admXfWNsY2OdvQtoikELv+azF9VuWkYQWqDqmetaeZzs/vxhXOGPDlv6LcUX1B5f9xcsHQBVRjYGqYrDt+pYQrgfWnpq6QCoM7LxuNXdDkZ2toSwZekAqDuyo45/mw+EFqhz");
            WriteLiteral(@"uWDUg291cNUfWKMFUkY2PqU+6ehywUWnoaVfu2QMzGiBpLZ6EtlrCS2Q0oc9+l6PhRaow3qPvtep0AJ16NOywWjuhDPD+T/wYhiQTNHv0wNuh7buOakMILRpxROLTywdAClNev79x7cbW6MFknrR8+9/GH+xdAAk07M3LFwlN6MF0hXm/GxWH/V+HMxogQpmtoezp9E9E9/EsGFGC1ThYXbNO6c67Fn8RWiB9E+d8zyecGVjFp6e2Avf88HZ92/pAKhSeRHGR9n5UkIX36IbZ+7PZpE9O5TY8cQASR9YLB0ApCa0AEILILQACC1Afe4ZAtqiKIp4KFB8z/w0z/OpEUFo4W4RjQGNIR2G7d3s/NLNs+2yvz//n/G4xdPy9p/xNoR4YlRpCm9YoM64xiukPsjSHbgeYxtP0zcJ+/ixEaem/dwbFqh8pxuGbRy210W1TsK2U74rCYSW7i0LhG1Uxq4JDi9ePA+EljYHdqeG2etdZrkj9xRCS1t3rlGDA2uGi9DS6p1qPWxHRTuNy6MfQGhp7A61U7Tf6/JoCBBazGLNbmlLaB1Hy7I7UZz9jbNuXuU0Hnv70LvQWDa0znXAMjvQ43Czn3X3UtLxTRRH5Vt/YWFCy6KRjbPY3R58q/FB5NBhYCzD0gGLRraP4dkOPyt79gAsHSCy6YzNbDGjRWSrseEkNZjRkmJnGYnsZw69QIYZLauO7DDGxUi8Jc5oN8PPzqmh4KYZrdBy004SX3U/ybp7CNcyDsLPzkPDgKUDltXl42SXtVUeSwyWDlj4kThGZNdIXCsuHWx49xiWDlhk5xiEm6PmzmbjOToas9/GS+Vs2muwdMBd7TZ7ySCfC27tho6vxdIBd30EHmaOMrirabmE4CgEzGi5laeG4M4GYfPCGGa0mM0mFmez981qMaPFbDadNbNazGi56ZH37PyrRmIp0/DzdN8wYEbLVR4ZgqUNXHOMi4SW2aNufNorEKvxoSFAaLlMjKy32q5oLF3YEaHlMj83BCt/4AKhRRg8");
            WriteLiteral(@"cCG0VMKLNx64EFrSe2AIkjyADY0CQsuMy7KkIbQILYKQ2HuGAKElc5HBpAaGAKElcrxnOh7EEFrODA2BZwwILXjGgNDSal6wAaHFjKuCp/jprj02NLoILcTIFoVhQGghHSe+R2gh8Xz2TcqlAxBayMOPQW5Wi9BC6toKLUJLOi6NnRUpZ7QT44vQ8soQgNBCYkmXDabGF6HFU9uUCc9zoUVosUab0LEhQGiJMy4xSMdsFqHlMxNDkIQXGhFaPMX1AIbQUpWXhmDlTvM8F1qElnMhCAdGwWwWoSU9sV2tF4YAoUUYPHAhtNQQBsfUrmgs8zw3lggtbyvDYBa2Gh8bAt76+SqKIv6QGQlml8Y+MhJLmYafp/uGgbmfKzNa3prVxuNpJzXukg35GEv5yJ6EGS03PfoOw82hkVhIXH65b30WM1pumtVOMseALjybFVnMaDGrTWcatg2hxYyW24oz2j3DcCdPRBYzWu70CByshe2kvOWGB6bwM7RpGDCj5a7i7OyZYbjVOG0bBq4jtFzneeZNDDd55nI1WDpg0aWDGUsIV4tvtX1oGLB0wCqeGlt//KJjSwZYOkBU0j74bDvKAKFl1fYyL459NsN3UUuEllR2MsfXPhFZ7uqeIeCiG14c3S5fLBv1cGjicsGePQShpYoQ9y22cbngoYstsvDPjMO7WFTYd2Joxz2IrDVZlvk5EVqW3omG4WY/6+ZxtsdlZB1dwFKh9WIYyy4jxKfTG2WUuuR5+N6cjYuVEFpWEdt4+ZYY2y4c/jVbKnjinmVlPyOWDljx06RR1t51W+uxWDqgFbPbvez8ZDRtJLJYOqA1sY1Puyct+7K9EQFLB7Tu6dIgO790eRuORnDibiwd0MpZ7TRrz6W3nTAHM1pa/Wgez2U7aPCX+NwRBpjR0nZNPuTL5XqohNCS9inT+VEI04Z+eQfekIDQ0hUfm23T6wmHNVpSC/tYPPLgdcO+LEcaUNX+b0ZLBY/m50/Pm3Y13Y/dM1RFaKnKi4Z9PS6jjtDS");
            WriteLiteral(@"OU0KmxfBEFq6pwzbpCFfzkv3CEJLVzUlcBN3BUJLVzUhcKdOHoPQ0lkNubihyCK0dF7dobM+i9DSeVMzWoQW0nrV89AjtNDt0HkhDKFFaNPyJgWEFqFNzGwWoaX7ykvcgNBCR1k6QGghsVeGAKGlL6yVIrTgKTwILUBr3DMEVO0n739gEDCjBUBoAYQWAKEFEFoAoQXgRg7vonI/+P7/avvcf/mz8Udo6YG//s1uR79YOgAQWgChBUBoAerjVQkq56gDhBYSc9QBfWPpAEBoAYQWAKEFEFqAzvLyL3X4OGwvL/uDf3zy9wf/+fe/hot+4B++t/7sy1/+ylV/PDH01KIoCoNAkwzibrngdmj4aGRjhZYGGi8Y2qGhQ2jhdoYLRPbEsNHU0N6zfHC5PM8NQn0m5XaXGeozw0ZTeTGMpvpo9puvf/0b6++8887a/B++fv2f408//fR07n/tGTIaO3EzmzWjbbrf/u73h5fMbjf/9Mc/TIwObVg6cBwtQGJCCyC0AEILgNACCC2A0AIgtABCCyC0AAgtgNACILQAQgsgtAAILYDQAggtAEILILQAQmsIAIQWQGgBEFoAoQUQWgCEFkBoAYQWAKEFEFoAhBZAaAGEFgChBRBaAKEFQGgBhBZAaAEQWgChBUBoAYQWQGgBEFoAoQUQWgCaEto8z5fagkFRFI/Ddhh+X1zcgv1wOwrb2h0+JoAZbQjoWth2wm9PQhx3wza8IuRb4WYc/u7JmzdvHrurAKG9XWQH5Qz26R1mznFGuxtiux8j7S4D2uZexZE9iuFccKliK36M8NsNdxtgRnt5aPcXjexcbNfDzHbX3QYI7RcjuxMjuYqPFT5OfAFt6K4DhPbzyMYXvx6t+GM+ddcBbbGyNdoyqKPw2wdhW5v7/6fLLhlcMqsdho+7Hm6P3YVAL0IbAxu23VUH9YbPGZcPhBbo/tJBeYzruMrIlh64+4DOz2jDrDK+qaCuowAcUwt0f0YblwsMIUCiGW05mx0YQoB0M9r1mr92");
            WriteLiteral(@"L4QB3Q5tmNG+V+cXHt+48ObNm3jCmbFzIABdndHWLsR2ELZ4aNlJeR4EgO6ENgTuVYOCu+aFOaCLM9pGrZGW568F6NSM9iDMIqeGEOB6S71hIcR2O9wcGkb47G3hcXs3u/rQx5dhixOUSfj5MVER2luFdhJ2rhjbcQN28j3XDaOG/W4Ubn4ettsuXQ3n/m0M7UHYPhJdSwc3xXYv3DyscxkhfO7j8HU8cXdS4T63E492KScZi74+EGe98Vwh8aiZeKmmdSNrRntdbOOj8kF5Fq8HWbXvGHsRYx+20/C53aOkDuzs/B6r3sfjx42Xa4oTlydxfzbaHQvtqp5yl7Pbvbq+GUsHJAzsWhnYUeJPNSqD+zAuzRl5SwfQl8jG2ethBZGdiVE/DJ/3sdEXWuhDZOO66VFWz7k9dsPnH7sXhBa6HtnDrN5zH4/EVmihq5GNcR1nzTjB/Kg8jAyhhU4ZZ/WfCvStr8fhX0ILXZrNxtljE8+dse/eEVroypJBU88EN4hvlHAvtc89QwBviYdUNflE8o9CbJ9f94aG8sEiLjMMw/bV7PMlkPhvXpW38VwLrlIitFDLbPZRw7/MtfLBYOeSr3+U3Xzeha25vz/NnGvB0gFUbJS14zL2jy4EdmvB8y4Mss/PtTB2lRKhhSp82JKvc62Ma7yNx/nuZ8ufeyE+yBx5N5qlA7js6X4MzDBss5MZDeaiMy23uBYZ1yYPrlrbLD9Omw6fepSt/jjfsxcC44VXy3NNY0ZLn33wwfvDcjY3e8o8KoM7uPDUeFg+PY5/53V5OsLhJR9y2LIhGGbpljm8G82Mlj771re+mf3ql7/Ivve97z5d8EPMTkc4Cbfbcy8CPTC6X4htZmYrtPRvFpt98LOfrnJGGF8Eiud+fZ5Vew7lNsX2VTk+CC1d95vtX2c//vGPUnzoszXJrF3rs1V6GsbnwOFfy8nLpwdGgsb65JN/HH3nO98WwvrsWUJY3FljhZaG76SzF7qo132z2sVD66gDmryDbolsYzwy");
            WriteLiteral(@"BJYO6F5k46FL8dCtNaPRCNPQifuGwYyWbmn6yV36ZuB8uIsTWpo6m/VUtXmGhmAxDu+ijpAOsvM3DsTDqgYX/vhldn5qP7PZ5nGfCC0tCWx8R9fIrKmV3jMEQkuzIxvjumtWZEYrtJAmso6Fpde8GEbqyO6IbGe49I3Q0sDIDrPzNVm64b+GQGhpHpHtlokhWIx3hpFyNntoJDoZ2ngI3p5zH9z6Z0FoSbZzeQGs++IVdLevu/Q5QkvanSuep2BgJDovRnYzNMQLZUJLDTtXYRR6Iy4hbJjZXh1aL4YBy4rPXHYNw9XMaDGjZVWcHNyMFkhsyxBcTmhJxcymf941BEJLtSaGoHecGFxoqdgLQ9A7jjoQWqqU53k8mH1qJHrllSEQWqq3bQh65cAQCC3Vz2on4ea5keiFiXeHXfOz4DhaUnPeg17YENor938zWiqZ2W6b2XbatshaOqAZsX0SbjYzh311STzK4GG4b/cMhaUDmvdUKh5v+WF2ftxl3Fz0r13i7DUevvfciWRut3QgtDTeb3/3+3gC8eGF/735pz/+YbLkD8AgcyrHOwVWWBcLravg0t+nc+cnQJkaCVKzRgsgtABCC4DQAggtgNACILQAQgsgtAAILYDQAiC0AEILILQACC2A0AIILQBCCyC0AEJrCACEFkBoARBaAKEFEFoAhBZAaAGEFgChBRBaAIQWQGgBhBYAoQUQWgChBUBoAYQWQGgBEFoAoQVAaAGEFkBoARBaAKEFEFoAhBZAaAEQWgChBRBaAIQWQGgBhBYAoQUQWgChBUBoAYQWAKEFEFoAoQVAaAGEFkBoARBaAKEFQGgBhBZAaAEQWgChBRBaAIQWQGgBhBYAoQUQWgCEFkBoAYQWAKEFEFoAoQVAaAGEFgChBRBaAKEFQGgBhBZAaAEQWgChBRBaAIQWQGgBEFoAoQUQWgCEFkBoAYQWAKEFEFoAhBZAaAGEFgChBRBaAKEFQGgBhBZAaAEQWgChBUBoAYQWQGgBEFoAoQUQWgCE");
            WriteLiteral(@"FkBoARBaAKEFEFoAhBZAaAGEFgChBRBaAKEFQGgBhBYAoQUQWgChBUBoAYQWQGgBEFoAoQVAaAGEFkBoARBaAKEFEFoAhBZAaAGEFgChBRBaAIQWQGgBhBYAoQUQWgChBUBoAYQWAKEFEFoAoQVAaAGEFkBoARBaAKEFEFoAhBZAaAEQWgChBRBaAIQWQGgBhBYAoQUQWgCEFkBoAYQWAKEFEFoAoQVAaAGEFkBoARBaAKEFQGgBhBZAaAEQWgChBRBaAIQWQGgBEFoAoQUQWgCEFkBoAYQWAKEFEFoAoQVAaAGEFgChBRBaAKEFQGgBhBZAaAEQWgChBUBoAYQWQGgBEFoAoQUQWgCEFkBoAYQWAKEFEFoAhBZAaAGEFgChBRBaAKEFQGgBhBYAoQUQWgChBUBoAYQWQGgBEFoAoQUQWgCEFkBoARBaAKEFEFoAhBZAaAGEFgChBRBaAIQWQGgBhBYAoQUQWgChBUBoAYQWQGgBEFoAoQVAaAGEFkBoARBaAKEFEFoAhBZAaAGE1hAACC2A0AIgtABCCyC0AAgtgNACCC0AQgsgtAAILYDQAggtAEILILQAQguA0AIILYDQAiC0AEILgNACCC2A0AIgtABCCyC0AAgtgNACMCcvisIoACT0fwEGAL+BBlr+j4JHAAAAAElFTkSuQmCC""");
            BeginWriteAttribute("alt", "\r\n                     alt=\"", 31214, "\"", 31283, 1);
#line 179 "WelcomePage.cshtml"
WriteAttributeValue("", 31242, Resources.WelcomePageImageText_LightBulb, 31242, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 31284, "\"", 31333, 1);
#line 179 "WelcomePage.cshtml"
WriteAttributeValue("", 31292, Resources.WelcomePageImageText_LightBulb, 31292, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(@" width=""346"" height=""658"" /></div>
            <div class=""bottom"">
                <img src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAABLwAAADKCAYAAACv61n1AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAKsZJREFUeNrs3VtsXPed2PEzc87ceBlxJFKKR6Iskk5sL1U1m6hoyVYdF4VhAoMt7D64LwEmfUqQPGwKC32owTgbgy/BGNuXBA7ysNA2C7RddJ3dxQBFXTQQ7I4LrNEkgp2E3shkZVqOJVO8Dzn3nj95KFPk3M7M/9zmfD/A0VDkmXPO/M9l5vzm9//9g4qPZfOpaQUAAAAAAAB9Jejz1/+vOAQAAAAAAAD6i28DXkZ2V0J/nOIwAAAAAAAA6B9+zvA6DHTRrREAAAAAAKCP+DngNX3sEQAAAAAAAH3AlwGvbD6V1B8Sxn9Ft8YEhwIAAAAAAEB/8GuG13Sb/wMAAAAAAMCjCHgduMyhAAAAAAAA0B98F/Ayui8mj/16Uv99jMMBAAAAAADA+/yY4TXV5Pd0awQAAAAAAOgDfgx4NQtsTXI4AAAAAAAAeB8Br/a/BwAAAAAAgIf4KuCVzadaBbVi+t+nOCQAAAAAAAC8zW8ZXtM9/h0AAAAAAAAu57eAV7sMLgJeAAAAAAAAHuebgFc2n0rqD4k2syX0+RIcFgAAAAAAAN6l+ei1Xu1wPpHl9TaHBgDguGuZXN3M/G/dSAdoNQB+vQZyPQQAOMlPXRonO5zvMocFAAAAAACAd/ki4GV0U0x2OPukPn+MQwMAAAAAAMCb/JLhNW3x/AAAAAAAAHAJvwS8pkzOP8mhAQAAAAAA4E19H/AyuieS4QUAAAAAAOATfsjw6iZbK5bNp6Y4PAAAAAAAALzHDwGvaZufBwAAAAAAAAcR8JL/PAAAAAAAADiorwNeRrfEWJdPT+");
            WriteLiteral(@"jPT3CIAAAAAAAAeEu/Z3hNO/x8AAAAAAAA2IyAV2uXOUQAAAAAAAC8pW8DXkZ3xF67JE7qy4lxmAAAAAAAAHhHP2d4TbtsOQAAAAAAALBBPwe8ZHVHJOAFAAAAAADgIX0Z8DK6IU5KWtwkhwkAAAAAAIB39GuGl8ysrFg2nyLLCwAAAAAAwCP6NeAlOytrikMFAAAAAADAG8jwcmZ5AAAAAAAAsEjfBbyM7ocxyYtN6MtNcrgAAAAAAAC4Xz9meFnV/ZDi9QAAAAAAAB7QjwEvq7ofXuVwAQAAAAAAcL++CngZ3Q4TFi0+qS8/xiEDAAAAAADgbv2W4WV1t0OK1wMAAAAAALhcvwW8rO52SMALAAAAAADA5bR+eSFGd0OrR1KkcD0AwPOuZXJ1L2//WzfSAfYiAL9eB7kGAkBn+inDy47sq1g2nyLLCwAAAAAAwMUIeJk3xWEDAAAAAADgXgS83LseAAAAAAAAdKEvAl42dzNM6OtLcugAAAAAAAC4U79keNmddUXxegAAAAAAAJfql4CX3XW1rnLoAAAAAAAAuJPnA15G98KEzatN6uuNcfgAAAAAAAC4Tz9keE37bL0AAAAAAABogYCX99YLAAAAAACAFjwd8MrmU6Iro1MjJlK4HgAAAAAAwIW8nuHlZJZVLJtPkeUFAAAAAADgMl4PeE35fP0AAAAAAAA4xrMBL2OURKczrMjwAgAAAAAAcBkvZ3i5oYZWIptPJTmMAAAAAAAA3MPLAS+3ZFdRvB4AAAAAAMBFCHj17iqHEQAAAAAAgHt4MuBldCOMuWRzkkY9MQAAAAAAALiAVzO83JZVRfF6AAAAAAAAl/BqwMttdbMIeAEAAAAAALiE5wJe2XwqoT+4bWRECtcDAAAAAAC4hObBbXZjNlUsm09NX5+9+T6HVG/SuUw8l76xSUtAlmuZXP347966kQ7QMgCsvM6YZeV16fj2cQ0E4LfrIAB/8mKXxssu3a4pDicp/k06l5mjGQAAAAAAQLc8FfAyRkN0a/");
            WriteLiteral(@"dB6njJ8aI+zdAMAAAAAACgW17L8HJzUCmRzaeSHFLdE90ZjX1MhhcAAAAAAOia12p4TXpg++5yWHXtMNA1ns5lpnPpG9REA/qcjJofVqCOCACug1wHAQDeRoaXXFc5pHoy2+RnAAAAAACAjnkm4JXNp0RR+JjLNzNp1BlDd+aa/AwAAAAAANAxL2V4TbOd/Ut0YdQf4kd+NWPU9AIAAAAAADCFgJd/t9NtXmzwO7o1AgAAAAAA0zwR8DJGP0x4pE0nOay60ii4RbdGAAAAAABgmlcyvLwURIpl8ymyvExI5zLjSuPMOAJeAAAAAADANK8EvLw2+uEUh5YpM01+HzdqewEAAAAAAHTM9QEvY9TDpMfalSCNOXNd/g0AAAAAAOAEL2R4eTF4lDDqjqEzrYrTE/ACAAAAAACmEPCyDsXrO5DOZURAK95q/xs1vgAAAAAAADrihYCXVwNHVzm8OjIjaR4AAAAAAIB9mps3zhjtMObRtk2K+mPXZ2/ucpi1NNfhPP+VpgIAuMm1TO4Z/SFDSwDw8XXwkv7wCi0BwI00l2+f10c7FAG7dznMGjO6KnbSXXGW1kKbD1t1WfO/dSMdoEUBtLmGPGPc4D3jxetgu3m5DgLo4DpyybgOfp3WAOBWbg94eX20QwJerXVakD6ezmVmc+kbeZoMAODgDd4zissCXQBg83VwRH/4jj79sT6N0CIA3My1AS9jlMOEx9uXwvWtmRmB8Tl9IuAFAHDiBu8ZhUAXAK6F31MIdAHwEDdneE33QfvGRB2y67M33+dQe1Q6lxEjM5opRj+nUB8AAGDvzd0zCoEuAFwLv25cCy/RGgC8hICX9UQdMgJeJ5mtyzUuan7l0jc+oukAeOgmoe70NlCPqav99oxCoAvoi+sh18Cer4V/phDoAuBRQTduVDafEl0Zk33SxtMcZg3N2fQcAADM3OD9XH8Q0zO0BgCuhQS7AHhX0KXbNdVHbZww6pHhUTM2PQcAADOeoQkAgGshAO9za8Cr37KiKF5/RD");
            WriteLiteral(@"qXEft3vIunzhm1vwAAAAAAAJoi4GWPqxxqj+ila+IszQcAAAAAAFpxXcBLjGrYh+2c1F9XjMPtoTmHngsAAAAAAHzAjRle/VrkneL1yn53xniPbUEdLwAAAAAA0BIBL16X3XrN0Bo3aoABAAAAAAA05KqAlzGaYb92/aNw/QEZXRKp4wUAAAAAAJrSXLY9/VzcPSbqk12fvfm+z485GcGqF/XpJ5y+/eVaJlfvh+1460Y6wN4E4OVrYS/bwDUQAAC4hdu6NPZ7FtSUnw+2dC4jgl1xCYuaNmqBAQAAAAAAnOCagFc2n0roD8k+b2+/1556TuKyGK0RAAAAAAA05KYMLz8EgxJGnTK/mnXpsgAAAAAAQB9xU8DLL939fFm8Pp3LjCtyg5pkeAEAAAAAgIZcUbQ+m0+JkRn90t1PFOZ/24fHmuwAVTydy0zn0jfe5zSG38gsak2BaQBcB7kOAgDQj9yS4eWn2lZJI8DnNzMWLPNFTmEAAAAAAHCcWwJefuvm58fi9VZ0QaSOFwAAAAAAOEFzyXb4LQAkXu+7fnmx6VzGqnpb06I2WC594yNOZXdq1eWELiQAAAAAAKs4nuGVzadEsXq/dfHzW0ablQXmZziNAQAAAADAUW7o0ujH7n2xbD5l3etemB/Qp6dc9HqtDEo5Nlrj4vLElJi4jAAAAAAA4C5u6NI47dO2F4ESq0YY/Io+Pa5Pv3X6RYqRFPWHcQtXMeeCY/c2lxIA8B6ZI/0BANdBAHAXRzO8svlUQn9I+LTtrQz0fVU5CHq5geWF5S2sEdbJPvRrwBYAAAAAANdyukujn4MFiWw+lbRo2aI746iyMH/RBa/TjmCU7XW8FpcnDoO1CeNnAAAAAADgEk4HvC77vP3lF69fmBeZXQPG/xyt45XOZeKKPcEoJzK8ppv8DAAAAAAAHOZYwCubT4mRGSd93v5XLVjm00d+vubw67MrEDWezmXGbX5tl5v8DAAAAAAAHOZkhhdZMYqSNAJ/Mh2t3XVxf8RG58zauC");
            WriteLiteral(@"7bsrwWlyeOB2snjd8BAAAAAAAXIODlPHntcFCza/TYb50sXj/Xp+ua5ngGAAAAAMC9nAx4TdL8+2QGShrV7PqqEy8qncuI1xW3cZUzRs0wp45djmcAAAAAAFzCkYBXNp8SwRC6gB2QGShpVLPLqQyvFx1Yp11dKMnwAgAAAADAxZzK8Jqi6R+KGQHA3hzU6rrY5G9OBL1mHVin5d0aF5cnxLHbKFgbM/4GAAAAAAAc5lTAi2yYR8kIlLQKatnardEYMdGJfTzn8LHLcQ0AAAAAgAtodq8wm08l9YcETf8IESj5mx6X0Sqo9ZTNr2fGoXaMi9phufSN9y3eV1buRwAucy2TG9EfvqNPf0xrAPDpdfB5/eFPaQkAgJc4keFFce+TEkYgsBetglqjxgiOdplzsC0tW/fi8oQI1LYK1iaMeQD0xw3eiD59T/9xSZ9e0acRWgWAz66Dl/Tp5/qPb+jTJVoEAOAlTgS8rtLsDXUfCDyo0TXQZi47uzXOOtiOVgbbpiXNA8D9N3nfUwh0AfD3dfBPjevgM7QGAMCLbA14ZfMpkf2SpNkb6iUQ+HQH89hSuD6dy4iAU9zBdpzWt8Gq9V+WNA8A9yPQBcDvvkMTAAC8zO4ML0axay6ZzadiXT63k2DWRWVhftSG1zHjgraUnuW1uDwh9k0nWXiTxrwAAAAAAMAhdge86O4lu30OanN1Gsiyo3j9nAvacc7hfcNxDgAAAACAgwh4uUs37WMmiGVpHa90LjOuP4y7oB2tqCE2adG8AAAAAABAMtsCXtl8imBXe9200TUT81pdx2vOJe0YT+cysw7uG451AAAAAAAcZGeGF0GADpgKDC7Mi5EZL5pawcGIjlaZcVFTPidrQYvLE6L2nJm6XDHjOQAAAAAAwAGajesiANAZEfB6v8N5uwleiW6N/1f2RhsjI865qB3FtrwicZ9085zbHM7+cy2Tq9MKALgGAgAAOMuWDK9sPpXUHxI0d0fMBAa7qcllVeH6WZe147hRU0yGaZueAw");
            WriteLiteral(@"AAAAAAJLCrSyM3/51LGAHCTnQTvBo1RnaUbc6FbdnzNi0uT4hAbTfB2oTxXAAAAAAAYDMCXu7Uvr0OanENdLl8K0ZrnHFhO844fOxy3AMAAAAA4ADLA17ZfEpkuSRpalM6CZQ83cPypRauT+cyYnvHXdiOMrLOLjv0XAAAAAAA0CU7MrzIcjEvaQQKW+klaHVRWZgflbi9c25tyHQu0/W2LS5PiJEZJ3tY/aSxDAAAAAAAYCM7Al6Mzii73Q5qcPUasJJZvH7Oxe3Yy7bJCNYS8AUAAAAAwGaWBryy+VSMG/6utWo3GcEqKXW80rlM3OX7uJc6XpMS1j/JoQwAAAAAgL2szvDiZr97rYJI1yQsX1YdrzmXt+O4UWNM9j6wcxkAAAAAAMAEqwNe3Oz3IJtPnWy/hXkxMuNFKSs4GOmxV7MeaErT27i4PCG6lMqovxUzlgUAAAAAAGxCwMvdGrWfzBEWZXRrnPNAO845fOxyHgAAAAAAYCPLAl7ZfCqpyMmQ8bNGmUFflbj8nmqBpXMZkTkV90A7zhi1xswg4AUAAAAAgEdZmeF1lebtWcIIHB4lc3TFUWPEx24956G27DjLa3F5IiHaXuZ+NJYJAAAAAABsYGXAi6wW2e14UHNrQPLye8kYm/VQO846fOxyPgAAAAAAYBPNioVm8ynZGTJ+JgIlbxo/P23B8kUQ7Q2zT0rnMuOKt4I4Zup4XbZg/WKZb3M4w4uuZXJ1WgEA10EAAOAlVmV4kc0iT9IIIApfsWD5F5WF+dEunjfnsXaMp3OZtsfl4vKEqDs3acH6J41lAwAAAAAAi2kWLfcyTSvVlLIwf08RNbesIeqCmc0+mvFgO76oT6+0mcfKYK1Y9rtuaIhsPnVOORgUQQT3zhnTUTv6dNt4vHV99uZtTkMAAACg6efrIeOz9RV9Ovz5uFuHn7P1z9e3aDXAWpoFJ7pVGTJ+JgIlpy1cvqjjZTbgNefBduykjpeVx65YtmMBL/3cFAGuZ5WDYOW5Dp4yc+S54o");
            WriteLiteral(@"05r0/v6G/OeU5JAAAA+J3xJfKs8Rm7k/uIK0eeKx7eOfIZe5sWBeSyIsOL7ozWtOkTFi7fVFfJdC4z59V2FLXHcukbHzl0/DpybuhvpuKN9WtH32C7MGi8kT9rBL9E3bef8cYMAAAAvzE+X7+g9N7rZcaYdvRl8vkakMyKGl5kd0lWKGvaYKhsbbDkYARIMxdmr2q67YvLEyIDyso6WzFjHXa9EU/p0w/0H8V0ReKiRfBLBNBu6Mt/gTMUAAAAfiAyuo58vpZ5T3T08/XXjO6RAHpkRcCLDC/Jfr16ZjSmVYYtXs1XTcw75+HmnHP42LXl/BBvlPrDDxW5ga5Gb8zf0Nf1I6O7JAAAANCXjC96f2TD5+v9z/F8vgZ6F5R8ERA384xEJ9nSenw0rFYHLF7NU53MZIx0OO7h5mxVx8vzAS/xbZAIQBlvlHYRWZ0/0Nf7LGcrAAAA+onx+VoMfPUN5SAgZQdRG+yHfL4GeiM7w4sotAXuFwZG1EA9FFGrUQtXM6oszF/sYL5ZjzdnvFENssXliYT+kLBh/QljXVa8GYvz74biTLdi8eb/Em/KAAAA6BdG10LZ3RfNEJ+vX2JPAN2RHfCiO6Nk790fHS3XgvuDC7ikW+NcHzTrjMPHrvR1GcEu8WY86HDbEvQCAACA5x0Jdjldo/pZgl5Ad4ISLwhJxZ4MGV9Z2RoaOfw5qlWsLl7YsnB9OpeJK94uWH+oUdDuso3rl7quI2/Ggy5pX4JeAAAA8CwXBbsOiaDXN9kzgDkyM7wYndECH20Njx7+HArWolqwFrJwdReVhfnRFn+f65NmHU/nMg/rkC0uT8RsPn4njXXK4qZg16GXKLQJAAAAj3rJhfe3z/OlMmCOzIDXVZpTrpWtoaFCWXukbldUqzhZvH62j5r3aPDOia64UtZpfNPj1mDzd7VQmRMZAAAAnmGMxujWXi3f1LfvHHsJ6IyUgJd+0olslSTNKdcHDxInsq0cruM110fN63TAa1LCeSeGRH7exW187vGnf8");
            WriteLiteral(@"mJDAAAAE8wgklfc/Em7g8UxZ4COiMrw4ti9Ra4szl8IuAVVatWB7wa1vFK5zJiH8f7qHlnjJpkghMZUjLOGdf34x+7sKzEz9znZAYAAIAXiM/Xgy7fxivZfGqWXQW0R8DLpVZ3o9GNYqRhkfrBUNnaoNfCfKOg11wfNvPs4vKEOHZjDqw7pq+76xpXRv99T9TNu/DF9zmhAQAA4GpG7wmvDND1DfYY0J6sgBcF6yVb2jg10uxvDnVr7MeAl3hNThZW7yVQ/IJXGjl++r4yGF/npAYAAICbveChbT1HAXugvZ4DXvqJ5lSGTF9bWo83HS0xrFZtLVxvjGjYj1l8Mw6/rukuzzkRpPNUkPkLl/6ekxoAAACuZNTumvHYZhPwAtqQkeFFd0YL3N0eahrwUgP1UEStRi1c/aiyMH/xyP9n+rGNR0LF8fVyxMnAUWJxeSLRxfOe91pbnz73MSc1AAAA3MqLNbGuMGIj0JomYRlTNKNc790fHW03j+jWWKyqexZuhujWeMf4uR+7Mypj4V3ls1JsfCRUXHNwM0TA+G2zb25ubtfdihb8/c5gZH0vEnqw/vk4B4FzK8rug1ElWo5ykgMAAMB5C/OiZvLk//74d/+6UgueOfz1xfhWIapWao8N7RRd/gpEoO4NdiTQWE8Br2w+ldQfEjSjXLfXT7UNeEW1ypBSjFg5/N1Xjlw8+3IUkEsDm8pmJSy6a95ycDMuKyYCXkZ3Rtd9k7O2Fw393SdfGPl4eyi2uhuNPLzAFD8PbpWHPlVK2pai1lRlsDSgPP3tP//F6PaZf/vWjfQvOesBAABgi4V58Vn6WeMeZzIYqAff+Tj5SBKH/rn29MN7hlOb21Mj6zt/eO7epgtfzRWFgBfQVK8ZXnRntMC9wsBIu3lCwVpUC9ZClVqwbNFmXNTfDEbTX77zJf3neL+1sd5+okujUqypiVJNDYeD1ZJDmzK5uDwRe/LS0m6n87upHT/ZHoz8rzsXx/THtnX8gmp1/7EarCqb0S0xffnB0N");
            WriteLiteral(@"ovLrz0oz9Zee1b3+PMB+Bn1zK5P9Mf/h0tAQAWOQh0fU05VvtKvy+ItHra8kZ8SExvrZwf+4dn76+nxldWXfSqrrBjgRb3oD0+n4CXZCtbQ0OFstZRn6+oVrGjeP1z/djO56PbD3++VxoYd3hzzJxHrsnu+h9Ll8b+4tdPX+wk2CWoWuXE70pqWdmJFF5J/IfsL/ZCe1wAAPjZ1/Xp5zQDAFhgYV4Eum4oDQq9twt4PfzcWlWDIvPr9V9eubS0ccotg7YNZvOpIXYw0FjXGV76iSW6MiZpQrk+eJAY7XReUcdruxTesHBzRB2vvqzflYzuPPx5rRy5cCG6ddvBzRFZW+92OK/j3+KIGl3/+TdPXTjadbFTgUBdqdcDjf705d+dXVIurCWVkcIpLgQAWrqWydX79KV9mb0LwMfXQPkOanR9t9Vn6EBAUc0sUr//Cv23xS9e+GcXPr7/T5KfrLvgVYp7iVvsbOCkXro0UqzeAnc2hzsOeEXV6rClB0ew9k/1h/F+bOez4cLDnwtVzemsKc9kSooujH+5+KUL4huubp4vujVWK80vOyuJu/uPBL0AAADQk4Ng1w+UNiVBwmq1q2ytt1fOj90vDET+6Inbn9LYgDv10qWR7oySre5GoxvFiKmU1MFQ2bKgVzRUHVvfifRdO4vujKKG16FaPRD+rBRzMugVW1yecH0AWWR2/fXvph7rNtjVKRH0Wh/Y4IIAAACA7nQY7OrV4oNE/OZHF87Q4IA7dXXjms2nRBScgJdkSxunRsw+R3RrtGp7QlotsV4I9107j0VO1odfLUW9VMfLEX/1wReTIoXbjnWJoBc1vQAAANCllxSbBnsSdb1+s3qaOlqAC3WbqTFJ08m3tB4fNfucsFq1pHB9MFDXwmrt7NZuqO/a+Wj9rkM71RDdGlsQ31x1WpxeljtnVvZHdAQAAAA6tjAvCtPP2LnKN5cfPyd6Q9D4gLt0e1KS3WWBu9tDpgNeaqAeiqjVqOxtiYSqp8VjsaIqhZLWN208Ei");
            WriteLiteral(@"oqg2r5xO+LNTWxUw05+c1MYnF5IuHGNlvbi4Z+dW9sRMaymhSsb0iM4Lg6tMaFAQAAAJ056Mr4TTNPqdYC5V5XK0p+/M/lx8fYAYC7EPByiffuj452+1wrujVGtNrDC3Y/1fEaC+82/dv9YuyCw5vXyXlle1HMt1fOn5ZVt6tWNTUIjrI6+IAsLwAAAHTqeX0aNPOEaj1YkbFiUc9LfFHswGveYbcDjZm+ic3mU0n9IUbTyXV7/VTXAa+oVpGemRRSaw+zjdZ3+qeO16WBzaZ/26qGne7WeLmDeWwNeInU7KWNuJTjq14zHzMTwS4K2AMAAKBDz5r+vFnvPcPr0N998oURu1/w9dmbt9ntQGPd9FW7SrPJd68w0PXFMRSsRbVgLVSpBaVcrMNqbTgYqD8MaooujaWKqoQ1b2faiJEZRZfGZrYrIacL108uLk/Enry0tNtinlt2btBvV08POZXddWhtYEM5s32aiwTQpWuZXJ1WAMA1EH1vYX5W/9f0F9jlarAoaxM+3IiL7LL7Nr7qD9nxQHPd3MhSsF6yla2hoUJZ66kOV1SrSCteH9aqJ2pJ9UPx+vPR7bbzfFIcdPtojba+qd1eHxmUtaxqtbtjSIzWWFbLXCgAAADQypVunlSuBYv1eqAmYwPEiOafbA9aVg+mVg8Ei1U1djjd2RxeVRbmr7DrgcZMZXhl8ykRCEnSbHJ98CAx2usyRB0v/QIrpe9XNFQ9sY/XCmHlzPCep9u50eiMx22Ww+cei+x85OBmioDyu83+eH325rZ+Hn6o2BR4/mw3Ku0Nu1rpfvCD3dCeEqqGuFgAAACg1eforhSrwe2oVo3L2Ij/txmPPTa0Iy1rTAS59irqUKGijVRqwUc+m7+5/Pi/0B/+kbIwL/77jj69obz86i0OBeCA2TtQitVb4M7mcM8Br6halVK4Phioa2qwfmJZ/VC4/my40HaerUpYZHi96+BmdnKOvalP37BjY8S3VDKWI+p3ddulUdgLF5X43jAXCwvQ1QMA10");
            WriteLiteral(@"Gug0Cf6DrTaa+q7sgKeG0WI9K+pd2raEMbpdC5ej1womdWqarWfrN6+mgXlpn9aWFeBLx+rLz8KrW94HtmuzRO0WRyre5GoxvFiJSi4IOhcs8RgVioerbZ37wc9BLdGUUNr3bK9eDgejmScHBTY4vLE+3Oszft2BCZ6djlUk89dpVqgJEaAQAAYI29irYtq3j9/d2YlM/Q68XIufVi+LFGwS5haSPerF6LCPz9UFmYf5Y9C7/rOOCVzadEEXMyvCRb2jglbSQP0a2x12WEtFrTYM96wbujNY5Fdjt/cylHnB6tseV5Jro1KjYEvfaqWk/F6gP1wH4Gqf4mrVRKvR07oo4XAAAAYNln34q25ZZtEcGuvYraMuPs7ZXzD9os5iWCXvA7Mze0BLsssLQeH5W1rLBaHZCwjKYZXl4uXN9J/a5DG5WI2wvXCz91b2sHgsFK6IxailwU/6uUovtBLwAAAMCtdsramqzi9b3YKIbH2gW7Fh8kNtf2op1kpL1EUXv4mZmAF6MzWuDu9pC0gJcaqIciarXrvmORUDURCDSv61asqEqhpHmujUdCRWXQxCh/hap2rlRTnUxnSywuT7TsVnl99uan+sPPrNyIqFox/YYfrGqntGLkYrCqnhL/F4GucrH3rO7B0iAXCwAAAFimVg/UdsraqpPbIEZe3K1oLXsAidpdHWR3HfWKsjA/xB6GH5Hh5aD37o+Oyl5mL90ao1rz7K5DXqzjNRbeNf2ce6UBr2R5fWrVBpgZXSZQC8a0UuRisKKdOXpdKe4Okt0FAAAAT9guh9YrtWBPIyxeGN7a7fa5W6XQWLt5fnVvbL3D7K5D4pvj59m78KOOAl7ZfEoU0Y7RXHLdXj8lPeAV1SpdR+9Daq1tsfb1He/V8bo0sGn6OZuVkNN1vK62m8Go5fWalRsxFC61fDMVdbrUcjipT48pRs2uQ6JuV7UspxtstBThggEAAIBWbslYyEYx/GkvXRsjarWr0ZZEdlelFmz5ofeT7cHdmx9d6CYL7Q");
            WriteLiteral(@"UOD/hRpxleZHdZ4F5hYET2MkPBWlQL1kxHGfTnxNRgvW12mOjSWKqonmljMTKj6NJo1lYlfMHhTU8uLk+0DTJfn715MOywRc4P7TT5hioQVMuhMVGnK1ALnuhGW6uqSmlvQNp2DJYGuGAAAACglQ9lLKRcCxa3yqH73T7/8fhmVxleuxWtZd0u0ZXxrz744t1uP04rC/OzHCLwGwJeDlnZGhoqlLWoFcuOahXT0YGI1j6765CXitefj2539bxaPRBeL0cSDm9+R+fd9dmbbygWjdrYKCU7WNESok5XoKY2DJCKLox7O8PSujJGy1FFralcNAAAANDKLVkL0u/TNrdL5oNeoneEmbIgR1VqgabZXSLY9ZeLX1rZrWi9FNWnJjd8p23AK5tPiZv+BE0l1wcPEqNWLbubOl7hUHWs03nXCt7p1mhmdMbjPivFvFDHa9/12Zuia6P0oNdTZx5sh9Xq/htroKYO7tfpqmqJZtcO2cEuIVE4xQUDAAAArb38al6RWN9W1PParWjrZp7z9JkHW92ur1l3xsNg1yfbg8UeXxKjNcJ3OsnwIrvLAnc2hy0LeEXVqvmAl1o72+m8XipcfzZc6Pq5m5Ww0wEvU9/CGEEvqSM3xrRK7crptb2DOl2hc8frdB0lujHubsf3H2URmV0jBLwAAADQGalfAG8Uw/c3S+GOg2hXxj7blLl+icEuwJc6CXhdpZnkWt2NRjeKEUuHhh0MlTsOesXClbNml++FoJfozihqeHWrWFMTO9WQk0P4xhaXJ0wFnK/P3nxdOShkvyNrI6aC6mV9b7fsfiuK0+9ndtWCUhvgzM5pujMCAACgUz+T+TlYEN0b1/YiK+0K2V8Z+2w9Ed0ry1qvKFD/k1/9gyWCXUD3Wt6dZvMpUTQ7STPJtbRxasTqdZjp1hhWa6a7rK57oFvjWGS352WslaNOj9Y4ZfYJ12dvim+2vqVIqmMQDtaUyyONs7P3uzAWhvYnmd0Y99dbDSlnN0e5YAAAAKAzL79qySjmxa");
            WriteLiteral(@"q6e383uqQ/bje+n6rWro2vrMpYl8jqenvl/P2/+PXTvdbsAnyvXToG3RktsLQet/wuXr/odly4PqzVxswu3wuF63up33VorRxxerTGrs7B67M3P9Wnf6//+H1FQi2DJ+Pbytno518uieBWuRhTdrdO7Wd3WeHi6gUuFgAAADDnoJaX9Nq2tXqgtrYX+URke5VrwUe+Wf+jJz68K0qB9LJ8NVAvLz5IbP6n95++83/uPrZuQct8yMEBvyHg5YC720OWB7z0C2YoolbbjgIZVmvDwUA9Znb5xYqqFEqaa9t4JFRUBtXeM4oLVc3pDK/E4vJE11mW12dv5vUpoxx80/VOLxty7ewD5ZRWfRjoKu1FpWd1HbqwltwfnREAAADowo8ViwI8IttrdTe6IgJfIuPrXz5+59OJUxu9dC0R39L/7M/f/4P/8re/m/p0bS9atqhNbnFYwG/aRSwYulSy9+6P2tZHS3Rr1C/Ce63mCWvVrkfgFHW8BsIVV7bzWHhXynJq9UD4k+Lg+GORnY8cfDniPLzbywKMbo5vZvMpEcATI7TMGsttG9DbfDCmbK6eVdY+TSqntoeVB6N3lHpoz7IXK4JdFKoHAABA10TXxoV50dvhB1bd04rAlz795A/P3RN1w2aMz9hXOvl8rRwEn0RATnw5fRCIWvjn4vP5P7aoRXYUAl7woabpGfqNscjuytBEcv313089tbwR/4Id6yrXgnu/3xlcajXPmcHiVa2LGl6CCHb9wYU1V7bzs2N39rO8ZDgd2vvtk0Nr7zr4cu4+eWnpP1q1cP1c/1GTDwI/1d+Af3otk6sf/WU1WFWWRu8oe5KDXqI4/WMb5wh2AQAA+NBbN9Lyuw4szIsBqF5SDgJSsr2mvPzqm00+X4tA25UGf/q+6IHRYntvKJ0FzMx6U9/W1zjK4DetujRO0Tzy3SsMjNi1rlCwFtWCtaYFloKButZtsEsQXRpLFfeNoCdGZpQV7BK2KuFxh19ScnF5Imbh8rfNzCwCU0/cm1DObr");
            WriteLiteral(@"Uu/VbV98PRqR6oN513sDigTHx2kWAXAAAA5BGZXi+/+ifKQRfHVgV+h45NrUboEplZ324W7Orxc/ePLWiFHYuWC7heq4AX9bskW9kaGiqUNVsLE0W1StPi9ZFQ9XSvy3dj8frz0W2pyyvXg4M71dCQwy/LdeejGEHxyd8/oSSaBKlEBtjRqaKe7P4qRmIUXRgnPnucml0AAACwxsuvvqEcjGLeLEg1eWxqlBQgBoISWV3f0qfbFm2nyP56R/JSXzdGrwR8p2ENr2w+lWxykqMHHzxIjNq9TlHHa7sU3mj0t0gXozMet1YIK2eG91zVzjJGZzzufjF2YXCg/FsHX5YIeL3rtmM6VA0p59eSytnNMWUztqWsDWy07eooglwio2t4d1iJ7w1zYQAAAID1Xn71IGC1MC+ynZ5VPq+71Yq4sTgIQh0Eo+wguh7Kqj32ZpeZaEBf0FrcXEOyO5vDtge8omq1aUQhrFbP9rp8Ubjebc6GC9KXuVUNi770Tga8XD2AhAh8ndk+vT/tfzKIFJT3zv/mkXlGdk7tZ3OJeQEAAABHHGQ7vWFMom6WCHr992NziSDRa0aQzP7tk1Nw/2f6sl5nh8PPmnVpJOAl2epuNLpRjDjSLW4wVD4R9AqrteFAoO0onR1xU9BLdGcUNbxk266Exks1NezgS4stLk945rwUGVwnjrlqmGAXAAAA3OXlVxuNXvipI8Guz7dpe7/rpKL8tMFfxT3JuSPTyW1XlO8T7AIaBLyy+ZToypikaeRa2jg14tS6RbfG47+LhnrP7jq0Xgi7pp3HIruWLXu1HD3n8MtjIAkAAADAL15+VQS8MorI1vq86H6zgJcopi+6a37bxu6XgKtp3FTbY2k9PurUusNq9US6TVirjslavpsK11tRv+vQWjky/lhk5yMHX57I8PobziYAAADAJw4yzV7fnxbmxb26qD/23SNzfF+fbjuakQa4VLDJTTUku7s95FjASw3UQxG1+nAIvGCgrqnBurRq4cWKqhRKmuNtPB");
            WriteLiteral(@"IqKoNq2bLlFyohpzO8EovLE2RfAgAAAH50MDrkrWO/yxPsAhoj4GWD9+6Pjjq9DUe7NcYkdmc85IY6XmPhXUuXX64HB9fLEadHL53kjAIAAAAAoLVHAl7ZfIpglwVur59yPOAV1SoPC+aHQ/K6Mx5a33G+jtelgU3L1/FZKTbu8Mu8yhkFAAAAAEBrxzO8CHhZ4F5hYMTpbQgFa1EtWAsZP5+WvXzRpbFUUZ18fftdGq22WQk7HfBKLi5PxDirAAAAAABo7njAi4L1kq1sDQ0VylrUDdsS1SoDkVA1EQgolhTccrJ4/fnoti3rKdbURKmmOp3ORmAaAAAAAIAWHga8svmUKIadoEnk+uBBYtQt2yLqeEU1+fW7Dq0VnIsDWTk643H3SgNOZ3kR8AIAAAAAoIWjGV7UBrLAnc1h1wS8omp1OKzVxqxavihcX60FHHltZ8MF29a16fxojRSuBwAAAACghf8vwABfcA5F9k0oGQAAAABJRU5ErkJggg==""");
            BeginWriteAttribute("alt", "\r\n                    alt=\"", 46181, "\"", 46247, 1);
#line 182 "WelcomePage.cshtml"
WriteAttributeValue("", 46208, Resources.WelcomePageImageText_Skyline, 46208, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 46248, "\"", 46295, 1);
#line 182 "WelcomePage.cshtml"
WriteAttributeValue("", 46256, Resources.WelcomePageImageText_Skyline, 46256, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" width=\"1212\" height=\"202\" /></div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"content\">\r\n        <div class=\"bodyHeadline\">");
#line 187 "WelcomePage.cshtml"
                             Write(Resources.WelcomeHeader);

#line default
#line hidden
            WriteLiteral("</div>\r\n        <div class=\"bodyContent\">");
#line 188 "WelcomePage.cshtml"
                            Write(Resources.WelcomeStarted);

#line default
#line hidden
            WriteLiteral("</div>\r\n        <a class=\"bodyCTA longer\" href=\"http://go.microsoft.com/fwlink/?LinkID=398596&amp;clcid=0x409\">");
#line 189 "WelcomePage.cshtml"
                                                                                                  Write(Resources.WelcomeLearnMicrosoftAspNet);

#line default
#line hidden
            WriteLiteral(@"<div>
            <img src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADoAAAAdCAYAAAD7En+mAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyRpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMy1jMDExIDY2LjE0NTY2MSwgMjAxMi8wMi8wNi0xNDo1NjoyNyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENTNiAoTWFjaW50b3NoKSIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDozMjVCMDEwM0FBQkExMUUyQjdGNEEwODg0RjhFODY4OCIgeG1wTU06RG9jdW1lbnRJRD0ieG1wLmRpZDozMjVCMDEwNEFBQkExMUUyQjdGNEEwODg0RjhFODY4OCI+IDx4bXBNTTpEZXJpdmVkRnJvbSBzdFJlZjppbnN0YW5jZUlEPSJ4bXAuaWlkOjMyNUIwM");
            WriteLiteral(@"TAxQUFCQTExRTJCN0Y0QTA4ODRGOEU4Njg4IiBzdFJlZjpkb2N1bWVudElEPSJ4bXAuZGlkOjMyNUIwMTAyQUFCQTExRTJCN0Y0QTA4ODRGOEU4Njg4Ii8+IDwvcmRmOkRlc2NyaXB0aW9uPiA8L3JkZjpSREY+IDwveDp4bXBtZXRhPiA8P3hwYWNrZXQgZW5kPSJyIj8+I1MZRAAAA4FJREFUeNq8md1x2kAQx3UaCoAKAg0YkgYQHTgV2KoAeMqjncfkBbsCSAd0AK5AOA1Y6YAOyJ7mf5rV6T4l8M3c2ALd/fZ/u/exh0gCy+VyyeiPrHPtqzPVd6p7IcTJ0rbxTO8FMe++/vIy/xY/TiF9CY+4If1ZUV1SHQb0V1L9Q/WFxJy7CCVxnZkk+hwtlIyTsCcGk53sMZJ8FGcY8Ux7NydB+xihJLI3k8Tug4TCi1uq92zEfpJxu4DwfoShY3y0o3a5Tyi82GKS0buA8G4xqV3uFAqRB4xYAoHPSURBH08IvwosR9omFCIbTDI0iok+GkxdrC5UjuqjHnpdCry7xaOcs2uLkQ2mLfQCBTeY1Ne6JRRzcoPH731EWsQuqM+jYU7WzD4iLWIX1GfFTLVwU+HaG4gQ3WExSRhcDzcVrldhYl63mAJCnwEtybiJx0tjNvETtCk9c/YDq2OuFjUSWjPJuInHSy0mtSk9c7ZmSvEpvntQIxswaGeE2wG1IDEzh1fl+694XLKvejFJzMzh1RZTwMhCdkZGjSJWVr5SnjEHT44o+MDjaPrt91gxyahRxMraYtpORoiCmpmyvesYMfcqCNvEKyNsnkVoq3ezLkx4qcW0eRahXTOl0C94eI9caGxiM0uTEzvVdGI6xHqZAzbJT4aQO8ADoUWJzQ0nqX/sfyuTjO7EpHa54SRVM1Ntwl+rbALf+zTmwDDKJtf7SqYZvwhs92nMATrOTFDbsY2F9gwrITdywVM0Vqbae0YmP7ZZVlMj05KiTXnoqjieRx7vFHAYIDJh28KxK5OJH");
            WriteLiteral(@"AaIbDCFvsc5DO0sku3VMkqEvse5EuauIvF+gSgRqbbHrW7gSX4i2hn2uNUNPNliCi3LkA0nIV6NDPFCz2BYllExQ7waGeIFz2BSlmWUGLHtFUXy/o48TcOed3Umu62omI00DUVl5PdIwK+1t81UUm34vmYiAb8ZUzgS5eq+p4cnN7g5cCbyWqJsvO+J8GSDyXNc0+XYlr18RA5ZRt7/btjSnqsFwXE51mK68k3L/W+DqR8HRcAViFq5Xm1pGBP4wAyu751Crjs1z9ZM1wU1BLaYptsK4VktN9pRq0R9Y5/NMZL8slmC1ioSIu51ezNtkSACQ3HJckjXAX1v8nzsTxLwVBTT99OEiFxkMsNIVpu/J6yjhBpEG5mhv7vI8l+AAQB7WiwH/DuungAAAABJRU5ErkJggg==""");
            BeginWriteAttribute("alt", "\r\n                alt=\"", 49127, "\"", 49191, 1);
#line 191 "WelcomePage.cshtml"
WriteAttributeValue("", 49150, Resources.WelcomePageImageText_LearnMore, 49150, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 49192, "\"", 49241, 1);
#line 191 "WelcomePage.cshtml"
WriteAttributeValue("", 49200, Resources.WelcomePageImageText_LearnMore, 49200, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" width=\"58\" height=\"29\" /></div>\r\n        </a>\r\n    </div>\r\n\r\n</body>\r\n</html>\r\n");
        }
        #pragma warning restore 1998
    }
}
