# http2cpp
converts html to string include file for embeaded systems so you can use your favourite editor/IDE to write your IoT web pages 

```console
html2cpp index.html index.h index_h
```
will read a file like
```html
<head>
    <script>
        function test() {
            alert("test");
        }
        test();
    </script>
</head>

<body>
    test this
</body>
```
and out put it like this
```cpp
String index_h = 
"<head>\r\n"
"    <script>\r\n"
"        function test() {\r\n"
"            alert(\"test\");\r\n"
"        }\r\n"
"        test();\r\n"
"    </script>\r\n"
"</head>\r\n"
"\r\n"
"<body>\r\n"
"    test this\r\n"
"</body>\r\n"
;
```
