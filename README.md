
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
  ![image](https://github.com/user-attachments/assets/3e5592b0-1bed-4da9-8efc-dc297db6df3b)

- The program will display errors for incorrect actions, such as:
  - Attempting to connect the Client before starting the Server. ![image](https://github.com/user-attachments/assets/8fd79619-c98d-4758-b7c1-da880e017cd8)

  - Not entering a domain name or selecting the desired IP format before clicking "Query". ![image](https://github.com/user-attachments/assets/1bf2db96-b8ac-45d6-ad59-708e3fa748e2)


### Topic 7: Client/Server File Retrieval Program

#### Main Features
- The Client sends the Server the path of a file located on the Server, and the Server returns the content of the requested file. Multiple Clients can connect to the Server simultaneously.

#### Installation Guide

1. **Forms**:
   - The program consists of two forms designed as follows:
     - **Client**: ![image](https://github.com/user-attachments/assets/94c66eeb-e61a-46b7-9236-dd49c9329a44)

     - **Server**: ![image](https://github.com/user-attachments/assets/adc2cfd9-651d-4831-9856-a912dc981dc3)


2. **Client Side**:
   - Create a `TcpClient` with hostname `127.0.0.1` and port `8080`. Create a `NetworkStream` and send the Server path as a byte array. Wait for the Server to return the byte array. If the file is text, convert it to a string and display it; if it’s an image, display it in a picture box.

3. **Server Side**:
   - Create a `TcpListener` to listen for connections and accept incoming `TcpClient`. Similar to the Client, create a `NetworkStream` for data transfer. When the Server receives a byte array as a path, it checks if the file exists. If it does, it sends the file content as a byte array to the Client. If the file does not exist, it sends a byte array of the string “-1”, and the Client will notify that the file does not exist and terminate.

#### Usage Guide

- Open the window and press the "Server" button to start the Server and the "Client" button to open the Client. To move the form, click and hold anywhere on the Client form that does not contain buttons or textboxes, and for the Server, hold between the two images.![image](https://github.com/user-attachments/assets/41a7128a-ce16-4722-97c3-051300a4ab9c)
- Start the Server by pressing the "Off" button.![image](https://github.com/user-attachments/assets/79ba785e-7052-469b-a8f9-9c88f4924dd0)

- Enter the path in the "File Path" field on the Server and press "Connect". A dialog will open to save the file. Name the file and press "Save". The content will display on the form.
![image](https://github.com/user-attachments/assets/da88093d-de45-4a48-b836-40347babe1c5) ![image](https://github.com/user-attachments/assets/b1ec6616-2655-4aee-a6cb-25469651019e)

### Common Errors

- The Client attempts to connect before the Server is started. ![image](https://github.com/user-attachments/assets/632840ef-71c7-43c2-af7b-662ae257ec64)
- Only one Server can listen on the same IPEndpoint (`0.0.0.0:8080`). If two Servers are listening, the one started last will automatically stop and close the form. ![image](https://github.com/user-attachments/assets/1d1370b0-232d-4a0a-a848-7a03b682035a)
- If the Server path textbox is empty during the Client connection, a MessageBox will prompt for the path. ![image](https://github.com/user-attachments/assets/2ec49c3a-293c-4727-9ae4-efd415e1f644)
- If the user enters an incorrect path, the program will notify that the file cannot be found on the Server. ![image](https://github.com/user-attachments/assets/a98a8132-d836-49d8-9fd4-06dc4f5a5998)

### Topic 13: Mail Reading/Sending Program Using IMAP

#### Main Features
- Read emails, send emails, and view emails sent in the last 7 days.

#### Installation Guide

- The program consists of three forms designed as follows:
  - **Login Form**: Displays the list of emails. ![image](https://github.com/user-attachments/assets/74c543f6-a0a0-483e-961a-c06b32cca3a8)
  - **Email Content Form**: Displays the selected email content. ![image](https://github.com/user-attachments/assets/1c0fd757-f7d9-42de-ad7b-ebffe81f84d2)
  - **Compose Email Form**: Allows sending emails. ![image](https://github.com/user-attachments/assets/44bd3e0f-4c56-47f4-9132-a400df9b565b)

#### Usage Guide

- First, open the form to enter email account information (Note: password must be encrypted).![image](https://github.com/user-attachments/assets/47d41725-ccf3-4f4a-8a1b-3c519c93cdaa)

- After logging in, the interface will appear. ![image](https://github.com/user-attachments/assets/a5ea43d1-e05e-466f-93da-717d6d337a2b)

- Use the "Compose" button to send emails, "Renew" to refresh the interface, "Sent" to view sent emails from the last 7 days, and "Log out" to log out. ![image](https://github.com/user-attachments/assets/cc4b6dbd-1c0a-4966-a0fa-38d9e7ff9449)

- Click on an email line to display the content. ![image](https://github.com/user-attachments/assets/7abfa2bf-061b-4fb6-a748-b27dc993c638)


### General Requirements

1. **Evaluation**:
   - Prepare well for the practical requirements. 
   - Students must understand and perform the practical tasks independently and answer all related questions. ![image](https://github.com/user-attachments/assets/3ae24da1-81cb-4296-80bd-84ffdd41aa58)

   - Submit a detailed report of what has been done, observations made, and include screenshots (if any); explain any observations. ![image](https://github.com/user-attachments/assets/b0dd8fa6-2fad-4eaa-930a-d2350b5ba6e7)

## End
