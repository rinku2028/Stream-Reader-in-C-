# Stream-Reader-in-C-
Stream Reader in C#


C# StreamReader is used to read characters to a stream in a specified encoding. StreamReader.Read method reads the next character or next set of characters from the input stream. StreamReader is inherited from TextReader that provides methods to read a character, block, line, or all content.
 
 
 StreamReader is defined in the System.IO namespace. StreamReader provides the following methods: 
Peak – Returns if there is a character or not.
Read - Reads the next character or next set of characters from the input stream.
ReadAsync - Reads a specified maximum number of characters from the current stream asynchronously and writes the data to a buffer, beginning at the specified index.
ReadBlock - Reads a specified maximum number of characters from the current stream and writes the data to a buffer, beginning at the specified index.
ReadBlockAsync - Reads a specified maximum number of characters from the current stream asynchronously and writes the data to a buffer, beginning at the specified index.
ReadLine - Reads a line of characters from the current stream and returns the data as a string.
ReadLineAsync - Reads a line of characters asynchronously from the current stream and returns the data as a string.
ReadToEnd - Reads all characters from the current position to the end of the stream.
ReadToEndAsync - Reads all characters from the current position to the end of the stream asynchronously and returns them as one string.



StreamReader constructor takes a full file name or a FileStream object with Encoding, and buffer size as optional parameters.
 
