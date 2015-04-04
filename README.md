#使い方
1. AudioChanger.csを空のオブジェクトに貼り付けてください。
2. 同じ空のオブジェクトにAdd ComponentからAudio Sourceを2つ追加してください。
3. 下の方のAudio SourceのLoopにチェックを入れます。
4. インスペクタにあるMain、Introの中のSizeを使う曲の数に変更してください。（全部で15曲なら両方を15に）
5. 次にAudioChanger.csを開きます。5行目の
`const int numoftracks = 15; `
の数字を曲数の数に変更します。
6. 21行目以降のtrack1～15をそれぞれ曲名に書き換えてください。曲数を増やす（減らす）場合は適宜追加（削除）してください。
7. インスペクタのMain、IntroのそれぞれのAudioClipにオーディオクリップを割り当てていきます。イントロ付きBGMの場合イントロ部分をIntroに、メインループ部分をMainに貼り付けてください。同じ楽曲は同じ数字になるように割り当ててください。
8. イントロ付きBGMはディレイタイムを設定してください。単にイントロの再生時間にすると恐らくズレるので適宜調整してください。

利用例:[RPG BGM Pack for Unityのデモ](http://knamica.github.io/asset/demo/demo.html)

![参考](https://github.com/knamica/sources/blob/master/capture1.PNG)
