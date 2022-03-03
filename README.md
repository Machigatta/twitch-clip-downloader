# Twitch Clip Downloader

> Version: 4.0

A tool to download clips from streamers / categorys.
### Crawler
You can either use the category, channelname or both to filter the core-search.
Found clips will be filtered by the language-shortcut.

It is necessary to determine the daterange from where to search for.


### Direct Download
Use Links or Link-Slugs to que up clips and download those specific clips.

### Config
You have to register your application under [dev.twitch.tv/console](https://dev.twitch.tv/console) and grab the client-id and client-secret for it to work. The "redirect-url" is not needed.

### Compile
```bash
C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild .\TwitchClipDownloader.csproj  /p:Configuration=Debug
```
Under `/TwitchClipDownloader/bin/Debug` are the compiled files.