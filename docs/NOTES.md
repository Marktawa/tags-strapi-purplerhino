# Linux

```bash
# Get Ubuntu release version
$ lsb_release -a
No LSB modules are available.
Distributor ID: Ubuntu
Description:    Ubuntu 20.04.5 LTS
Release:        20.04
Codename:       focal
```

## ffmpeg
```bash
# Remove audio
$ ffmpeg -i app-demo.mp4 -c:v copy -an app-demo-an.mp4 && rm app-demo.mp4 && mv app-demo-an.mp4 app-demo.mp4

# Lossless speed up video and remove audio
$ ffmpeg -i app-demo-mobile.mp4 -map 0:v -c:v copy -an -bsf:v h264_mp4toannexb raw-mobile.h264
$ ffmpeg -fflags +genpts -r 240 -i raw-mobile.h264 -c:v copy app-demo-mobile-4x.mp4

$ ffmpeg -i app-demo.mp4 -map 0:v -c:v copy -bsf:v h264_mp4toannexb raw.h264
$ ffmpeg -fflags +genpts -r 240 -i raw.h264 -c:v copy app-demo-4x.mp4

# Convert video to gif
$ ffmpeg -i app-demo-4x.mp4 -vf "fps=10,split[s0][s1];[s0]palettegen[p];[s1][p]paletteuse" -loop 0 app-demo-twitter-f10.gif

# Convert video to gif, resolution: 720p
$ ffmpeg -i app-demo-4x.mp4 -vf "fps=10,scale=1280:720:flags=lanczos,split[s0][s1];[s0]palettegen[p];[s1][p]paletteuse" -loop 0 app-demo-twitter-f10-720p.gif

# Banner bear example
$ ffmpeg -ss 23.0 -t 1.8 -i input.mp4 -filter_complex "[0:v] split [a][b];[a] palettegen [p];[b][p] paletteuse" output_trimmed_enhanced.gif
```