A single page application  is a web application or website that fits on a single web page with the goal of providing 
a more fluid user experience akin to a desktop application. That's a good definition. Let's talk about what it kind of really means. In the past, the way

that web applications worked was like this, you have a browser and you have a

web server over here. You're sitting at your browser and you type in www.whatever.com,
and your browser sends a request to the server and says, "Send me the home page of that site."
Server sends it back to you, and you look at it, and you click again,
send another page. "Now send me this page." Now that page comes back. Now you
type something in the box, "Send me the search results for this term."
Server thinks about it sends you a new page back. You are always getting new pages, and
that's why we see a lot of reloading, especially in older websites. You're
always waiting for the page to refresh. A single page application doesn't do that
at all
It's a completely different approach. When you first come to the website,
behind the scenes your browser downloads a little program
in JavaScript. Comes down to your browser,
your browser saves it starts to run it. It is a complete application, as if you had
sort of installed a smaller application on your computer, but this is in your browser.
And it usually happens in just a few seconds, you don't even notice it.
Once that is running, you don't need to reload that page any more. That little
javascript program is going to control everything on your screen
and, if it needs to, it will communicate to the server over the internet and get
the information you need without reloading the page. That's why we call
it a single page application. It just loads that one time. That saves a ton of
bandwidth, a ton of time. It's much faster, it's a much more fluid experience. We've all
sat there waiting for a page to refresh. That doesn't really happen on a single
page application. A great example is Gmail. They are one of the leaders of the
whole single page application approach. You may notice that in Gmail, it never
really refreshes. You're clicking all over the place, email coming in, even new
email. It's obviously communicating with the server but it's just that same page.
And that's what's great about single page. Overall, single page applications
are great approach especially for more complex applications. It's faster, it's
03:05
better in a lot of ways, it is harder to build, but this I think is the way of the
03:11
future. It embraces html5 and JavaScript to forward-thinking common approach and
03:18
I highly recommend it. And we know lots and lots and lots of great javascript
03:24
developers who can help you do it. So if you have any questions get in touch, and
03:28
good luck on your project.

00:00
hey have you ever tried to learn about
00:02
OAuth and open ID connect but became
00:05
overwhelmed by all the strange
00:07
terminology and jargon there's also a
00:10
lot of conflicting information out there
00:11
which can be really frustrating the goal
00:15
for this video is to explain how these
00:17
standards work using simplified easy to
00:20
understand illustrations and I hope we
00:23
have a lot of fun let's get started in
00:34
the stone-age days of the Internet
00:36
sharing information between services was
00:39
easy you simply gave your username and
00:42
password for one service to another so
00:45
they could log into your account and
00:46
grab whatever information they wanted
00:49
hikes you should never be required to
00:52
share your username and password your
00:54
credentials to another service there's
00:58
no guarantee than our organization will
01:00
keep your credential safe or guarantee
01:04
their service won't access more of your
01:06
personal information than necessary it
01:10
might sound crazy but some applications
01:12
still try to get away with this today we
01:16
have agreed-upon standards to securely
01:18
allow one service to access data from
01:21
another the first standard we need to
01:24
cover is oo-oo-oo auth 2.0 is a security
01:29
standard where you give one application
01:31
permission to access your data in
01:33
another application instead of giving
01:37
them your username and password you can
01:39
essentially give one app a key that
01:42
gives them specific permission to access
01:45
your data or do things on your behalf in
01:48
another application the steps to grant
01:52
permission or consent are often referred
01:55
to as authorization or even delegated
01:59
authorization you authorize one
02:02
application to access your data or use
02:05
features in another application on your
02:08
behalf without giving them your password
02:12
what's more
02:13
you can take back that key whenever you
02:16
wish awesome as an example let's say
02:22
you've discovered a website named
02:24
terrible pun of the day and create an
02:27
account to have it send an awful pun
02:29
joke as a text message every day to your
02:32
phone you love it so much you want to
02:36
share this site with everyone you've
02:38
ever met online
02:39
who wouldn't want to read a bad pun
02:41
every day am i right however writing an
02:46
email to every person in your contacts
02:48
list sounds like a lot of work and if
02:51
you're like me you'll go to great
02:53
lengths to avoid anything that smells
02:56
like work so here's you everyone needs
03:02
bad puns a good thing terrible pun of
03:06
the day has a feature to invite your
03:09
friends the first step is to choose your
03:11
email provider and when you click on
03:14
your email provider you are redirected
03:18
to your email service your email service
03:25
then checks to see if you are currently
03:28
logged in if not you get a prompt to log
03:32
in after you log in or if you already
03:36
have an active login session you'll be
03:38
presented with a question similar to do
03:41
you want to give terrible pun of the day
03:43
access to your contacts assuming you
03:47
haven't changed your mind you click
03:50
allow you are redirected back to the
03:53
terrible pun of the day and the
03:55
application can now read your contacts
03:58
and that's the only thing it can do
04:01
terrible pun of the day can now send
04:03
emails to everyone you know and you'll
04:05
be the most popular person forever
04:08
ooofff for the win you've just stepped
04:13
through what is commonly referred to as
04:16
an OAuth flow the OAuth flow in this
04:20
example is made of visible steps to
04:23
grant consent as well as some invisible
04:27
state
04:27
we're the two services agree on a secure
04:30
way of exchanging information the
04:34
previous terrible pun of the day example
04:37
uses the most common 2.0 flow known as
04:41
the authorization code flow now before
04:45
we dive into more details on what oh ah
04:46
this' doing let's map some of the oauth
04:50
terminologies resource owner that's you
04:55
you are the owner of your identity your
04:58
data and any actions that can be
05:00
performed with your accounts the client
05:04
is the application in our example
05:07
terrible pun of the day that wants to
05:10
access data or perform actions on behalf
05:13
of you the resource owner the
05:18
authorization server is the application
05:20
that knows the resource owner where the
05:24
resource owner already has an account
05:27
the resource server is the application
05:31
programming interface or API or service
05:35
the client wants to use on behalf of the
05:39
resource owner sometimes the
05:41
authorization server and the resource
05:44
server are the same server however there
05:47
are cases where they will not be the
05:50
same server or even part of the same
05:51
organization for example the
05:54
authorization server might be a third
05:56
party service the resource server trusts
06:01
the redirect URI this is the URL the
06:06
authorization server will redirect the
06:09
resource owner back to after granting
06:13
permission to the client this is
06:15
sometimes referred to as the callback
06:18
URL response type the type of
06:22
information the client expects to
06:25
receive the most common response type is
06:27
code where the client expects to receive
06:31
an authorization code scope these are
06:37
the granular permissions the client
06:39
wants such as access
06:41
to data or to perform actions consent
06:46
the authorization server takes the
06:49
Scopes the client is requesting and
06:52
verifies with the resource owner whether
06:55
or not they want to give the client
06:57
permission client ID this ID is used to
07:04
identify the client with the
07:06
authorization server there's also a
07:09
client secret this is a secret password
07:12
that only the client and the
07:14
authorization server know this allows
07:17
them to securely share information
07:19
privately behind the scenes
07:24
authorization code this is a short-lived
07:27
temporary code the authorization server
07:29
sends back to the client the client then
07:33
privately sends the authorization code
07:35
back to the authorization server along
07:38
with the client secret in exchange for
07:41
an access token an access token is the
07:45
key the client will use from that point
07:48
forward to communicate with the resource
07:51
server this is like a key or a key card
07:54
that gives the client permission to
07:56
request data or perform actions with the
07:59
resource server on your behalf now that
08:04
we have some of the OAuth 2.0 vocabulary
08:07
handy let's revisit our example with a
08:10
closer look at what's going on
08:11
throughout the OAuth flow you the
08:16
resource owner want to allow a terrible
08:18
pun of the day the client to access your
08:22
contacts so that they can send
08:24
invitations to all your friends the
08:27
client redirects your browser to the
08:30
authorization server and includes with
08:33
the request the client ID redirect URI
08:37
response type and one or more scopes it
08:41
needs the authorization server verifies
08:46
who you are and if necessary prompts for
08:50
a login the authorization server then
08:54
presents you with a
08:55
form based on the Scopes requested by
08:58
the client and you have the opportunity
09:00
to grant or deny permission the
09:05
authorization server redirects back to
09:07
the client using the redirect URI along
09:11
with a temporary authorization code the
09:16
client then contacts the authorization
09:19
server directly it does not use the
09:21
resource owners browser and securely
09:25
sends its client ID client secret and
09:28
the authorization code the authorization
09:31
server verifies the data and responds
09:35
with an access token the access token is
09:39
a value the client doesn't understand as
09:43
far as the client is concerned the
09:45
access token is just a string of
09:47
gibberish
09:47
however the client can use the access
09:50
token to send requests to the resource
09:53
server the client is like here's an
09:56
access token I would like the contacts
09:59
associated with the resource owner of
10:01
this token the resource server verifies
10:05
the access token and if valid responds
10:09
with the contacts requested it's also
10:14
important to note that long before you
10:16
gave terrible pun of the day permission
10:18
to access your contacts the client and
10:22
the authorization server established a
10:24
working relationship the authorization
10:28
server generated a client ID and client
10:31
secret sometimes called the app ID and
10:34
app secret and gave them to the client
10:38
to use for all future
10:40
exchanges as the name implies the client
10:44
secret must be kept secret so that only
10:47
the client and the authorization server
10:49
know what it is this is how the
10:52
authorization server can verify the
10:55
client now let's talk about open ID
11:01
Connect
11:03
ooofff 2.0 is designed only for
11:07
authorization
11:08
for granting access to data and features
11:11
from one application to another o auth
11:14
is like giving an application the client
11:16
a key that key is useful but it doesn't
11:21
tell the client who you are or anything
11:23
about you open ID Connect sometimes
11:28
referred to as oh I DC is a thin layer
11:32
that sits on top of OAuth 2.0 that adds
11:37
functionality around login and profile
11:41
information about the person who is
11:43
logged in instead of a key o IDC is like
11:49
giving the client application a badge
11:51
the badge not only gives the client
11:54
specific permissions it also provides
11:57
some basic information about who you are
12:01
where worth
12:03
enables authorization from one app to
12:06
another o IDC enables a client to
12:10
establish a login session often referred
12:14
to as authentication as well as to gain
12:18
information about the person logged in
12:20
the resource owner which is often called
12:23
identity when an authorization server
12:27
supports oh I DC it is sometimes called
12:30
an identity provider since it provides
12:34
information about the resource owner
12:36
back to the client open ID Connect
12:42
enables scenarios where one login can be
12:45
used across multiple applications also
12:49
known as single sign-on or SSO for
12:53
example an application could support SSO
12:56
with social networking services such as
12:59
Facebook or Twitter so that users can
13:02
choose to leverage a login they already
13:05
have and are comfortable using one way
13:09
you might think of oh I D C is kind of
13:12
like using an ATM the ATM machine is the
13:16
client it's job is to access data such
13:21
as your bank balance
13:22
and perform banking transactions such as
13:25
withdraw money from an account or
13:27
deposit money into an account your bank
13:31
card is the token that's issued by the
13:35
bank it not only gives the ATM access to
13:38
your account the authorization it also
13:41
has some basic information about who you
13:44
are your identity such as your name and
13:48
authentication information such as when
13:51
the card expires who issued the card and
13:54
the bank's phone number an ATM can't
13:58
work without the underlying bank
14:00
infrastructure similarly oh I DC sits on
14:04
top of OAuth and cannot work without the
14:07
underlying oo auth framework let's
14:12
revisit our terrible pun of the day
14:14
example the open ID connect flow looks
14:17
the same as ooofff
14:19
the only differences are is in the
14:22
initial request a specific scope of open
14:26
ID is used this lets the authorization
14:29
server know this will be an open ID
14:31
Connect exchange the authorization
14:35
server goes through all the same steps
14:37
as before and issues an authorization
14:41
code back to the client using the
14:43
resource owners browser the key
14:47
difference in OID C is when the client
14:50
exchanges the authorization code for an
14:53
access token the client receives both an
14:57
access token and an ID token as before
15:01
the access token is a value the client
15:04
doesn't understand the ID token however
15:07
is very different the ID token is a
15:11
specifically formatted string of
15:13
characters known as a JSON web token or
15:17
JWT JWT s are sometimes pronounced shots
15:23
a JWT may look like gibberish to you and
15:28
me but the client can extract
15:31
information embedded in the JWT such as
15:34
your ID
15:35
name when you logged in the ID tokens
15:39
expiration and it can tell if anyone has
15:42
tried to tamper with the JWT the data
15:47
inside the ID token are called claims
15:50
with oh I D C there's also a standard
15:54
way the client can request additional
15:57
identity information from the
15:59
authorization server such as your email
16:02
address using the access token well
16:09
that's it folks that is oo-oo-oo ID c in
16:12
a nutshell if you'd like to dig deeper
16:14
there are some additional resources
16:16
linked in the description below I hope
16:19
you found this video helpful please like
16:21
subscribe and leave me comments down
16:22
below I'd love to hear from you until
16:25
next time get out there and be awesome


mcurl -X 'GET' 'https://localhost:44334/WeatherForecast' -H 'accept: text/plain'
post -h Content-Type=application/json -c "{"name":"walk dog","isComplete":true}"
