
## Detailed Instructions
### Topic 6: Client/Server Domain Name Resolution Program

#### Main Features
- Create a Server program to resolve domain names. If a client sends a machine name, the Server will reply with the corresponding IP address.

#### Installation Guide

1. **Forms**:
   - The program consists of two forms: Client and Server.
   ![image](https://github.com/user-attachments/assets/09e088ba-92c6-4646-a9ea-61ca8d32ba3c)
   ![image](https://github.com/user-attachments/assets/ecb62a0c-87b4-4478-b2f4-624126a348ca)

2. **Client Side**:
   - Use `TcpClient` to connect to the Server. Upon successful connection, open a separate thread to receive data from the Server while the login panel disappears and the working panel appears.

3. **Server Side**:
   - After entering the IP address and port, use `TcpListener` to listen for connections from Clients. When a client sends a connection request, open a separate thread to receive domain names for resolution.

4. **Domain Resolution**:
   - When the Server receives a domain name from the Client, it will use `Dns.GetHostAddresses(<domain>)` to get a list of IPs corresponding to the domain and filter the list based on the requested format. If no IP is found, the Server returns an empty string.

#### Usage Guide

- First, enter the IP address and port for the Client and Server to connect (enter for Server and click connect first).
  ![image](https://github.com/user-attachments/assets/0d818416-a591-4a1f-a3d8-473551a9303d)
- After the Client connects to the Server, it can enter any domain name and select the desired IP format before clicking the "Query" button to send data to the Server for processing.
- The program will display errors for incorrect actions, such as:
  - Attempting to connect the Client before starting the Server.
  - Not entering a domain name or selecting the desired IP format before clicking "Query".

### Topic 7: Client/Server File Retrieval Program

#### Main Features
- The Client sends the Server the path of a file located on the Server, and the Server returns the content of the requested file. Multiple Clients can connect to the Server simultaneously.

#### Installation Guide

1. **Forms**:
   - The program consists of two forms designed as follows:
     - **Client**: 
     - **Server**: 

2. **Client Side**:
   - Create a `TcpClient` with hostname `127.0.0.1` and port `8080`. Create a `NetworkStream` and send the Server path as a byte array. Wait for the Server to return the byte array. If the file is text, convert it to a string and display it; if it’s an image, display it in a picture box.

3. **Server Side**:
   - Create a `TcpListener` to listen for connections and accept incoming `TcpClient`. Similar to the Client, create a `NetworkStream` for data transfer. When the Server receives a byte array as a path, it checks if the file exists. If it does, it sends the file content as a byte array to the Client. If the file does not exist, it sends a byte array of the string “-1”, and the Client will notify that the file does not exist and terminate.

#### Usage Guide

- Open the window and press the "Server" button to start the Server and the "Client" button to open the Client.
- To move the form, click and hold anywhere on the Client form that does not contain buttons or textboxes, and for the Server, hold between the two images.
- Start the Server by pressing the "Off" button.
- Enter the path in the "File Path" field on the Server and press "Connect". A dialog will open to save the file. Name the file and press "Save". The content will display on the form.

### Common Errors

- The Client attempts to connect before the Server is started.
- Only one Server can listen on the same IPEndpoint (`0.0.0.0:8080`). If two Servers are listening, the one started last will automatically stop and close the form.
- If the Server path textbox is empty during the Client connection, a MessageBox will prompt for the path.
- If the user enters an incorrect path, the program will notify that the file cannot be found on the Server.

### Topic 13: Mail Reading/Sending Program Using IMAP

#### Main Features
- Read emails, send emails, and view emails sent in the last 7 days.

#### Installation Guide

- The program consists of three forms designed as follows:
  - **Login Form**: Displays the list of emails.
  - **Email Content Form**: Displays the selected email content.
  - **Compose Email Form**: Allows sending emails.

#### Usage Guide

- First, open the form to enter email account information (Note: password must be encrypted).
- After logging in, the interface will appear.
- Use the "Compose" button to send emails, "Renew" to refresh the interface, "Sent" to view sent emails from the last 7 days, and "Log out" to log out.
- Click on an email line to display the content.

### General Requirements

1. **Evaluation**:
   - Prepare well for the practical requirements.
   - Students must understand and perform the practical tasks independently and answer all related questions.
   - Submit a detailed report of what has been done, observations made, and include screenshots (if any); explain any observations.

2. **Report**:
   - File format: .PDF or .docx. Focus on content and explanations.
   - Formatting: Use Times New Roman or UTM Avo font, size 13. Justify the text and center the images.
   - Naming format: LabX_MSSV1_MSSV2 (where X is the practical session order).
   - Submit the report file by the agreed deadline on courses.uit.edu.vn.

Late submissions or copied work will be handled according to the level of violation.

## End
