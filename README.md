Unity_CodeDOMSample
===================

CodeDOMでソースコードを自動生成してみた試作。

ソースコードはCodeGenerateのコンストラクタから生成。    
作ったソースコードはAssets/Entity/SampleCode.cs。消してもビルドが走って復活する。

[InitializeOnLoad]でコンパイル時に静的コンストラクタが呼べるのでそれを利用。（この方法はエディタがエラーになってると動かないので注意）

CodeDomの記述は http://msdn.microsoft.com/ja-jp/library/ms404245%28v=vs.110%29.aspx を参考にした。