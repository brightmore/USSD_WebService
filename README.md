# USSD_WebService
create a server for USSD in Mobile Network by web service is our goal
we deploy and describes request and response flow between the   http adapter and the 
internal/external applications which are running over HTTP/HTTPS.
All the request parameters or response headers are configurable and the below tables are 
showing the parameters which Server can send/receive towards the applications.in fact we have tree main object;
# 3 Main Objects
1-user dails with a number for instance *55585#( for connecting to  USSD Server)
2-a HTTP server get user's request and send it with GET method to HTTP Client
3-a HTTP Client Application is going to process request and make convenient response
# how You Can Simulate
there are different way for simulating USSD Application let me elaborate more
actually we use .net framework and c# then you can use WCF,Web service or Web API
I prefered to used asmx(web service)
