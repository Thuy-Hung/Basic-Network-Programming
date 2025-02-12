Project 6: Client/Server Domain Name Resolution

Installation Guide

The project includes two components: Client and Server.

Client uses TcpClient to connect to the Server.

Server uses TcpListener to listen for incoming connections.

When a client sends a domain name request, the server resolves it using Dns.GetHostAddresses().

Usage Guide

Enter the IP address and port for both Client and Server.

Start the Server first by pressing the Connect button.

Once connected, the Client can send a domain name and select an IP format.

The Server resolves the domain and returns the corresponding IP.

Common Errors:

Attempting to connect the Client before starting the Server.

Leaving domain name or IP format selection blank.

Project 7: Client/Server File Transfer

Installation Guide

The project consists of two forms: Client and Server.

Client:

Creates a TcpClient with hostname 127.0.0.1 and port 8080.

Uses NetworkStream to send the file path request.

Receives the file and displays its content.

Server:

Uses TcpListener to listen for Client requests.

Checks if the file exists.

Sends the file as a byte stream.

Usage Guide

Start the Server first by pressing the On button.

Enter the file path on the Client side and press Connect.

If the file exists, it will be received and displayed.

Common Errors:

Connecting the Client before starting the Server.

Multiple Servers cannot listen on 0.0.0.0:8080 simultaneously.

Entering an incorrect file path results in an error.

Project 13: Email Client (IMAP & SMTP)

Installation Guide

The project has three main forms:

Login & Mail List

Email Viewer

Email Composer

IMAP is used for email retrieval and authentication.

SMTP is used for sending emails with attachments.

Sent emails from the last 7 days are retrievable.

Usage Guide

Log in with your email credentials (encrypted password required).

View received emails and open individual messages.

Use Compose to send new emails.

Click Sent to review sent emails within the last 7 days.

Common Errors:

Incorrect login credentials.

Invalid recipient email address.

