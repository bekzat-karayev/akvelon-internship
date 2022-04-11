## Managed Threading Task 1 - ImageDownloaderApp

### Task description

At https://jsonplaceholder.typicode.com/photos there is a list of pictures as json. 
Implement downloading images from thumbnailUrl property. 

For solving this task you should use Threads. As the json parser you can use JObject.Parse method. For file downloading you can use WebClient.DownloadFile() method. 

It’ll better not to download everything in a row, but do it with throttling (lag) so as not to get a denial of service.

### Comments

Code comments and unit tests are provided.

[Link to original description](https://github.com/Rust1k/Internship-.NET-/blob/main/week%203/Managed%20threading%20task%202.md)

