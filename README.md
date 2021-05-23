# Arma3ConfigExtractorGUI

Config情報抽出GUI補助ツール

使い方
・画面左側
  「PBOフォルダ選択」
     解析対象のPBOのあるフォルダを選択
     フォルダ内の解析対象PBOファイル名がリストに表示される

  「出力フォルダ選択」
     解析結果csvを配置するフォルダを選択
     ダイアログでのフォルダ選択しづらい場合は、テキストボックスにフォルダパスを直接入力してもよい

  「全PBO解析」
     解析対象リストの全PBOを解析し、出力フォルダに結果を解析対象ファイル名.csvの名称で出力

  「選択PBO解析」
     解析対象リストで選択したPBOを解析し、出力フォルダに結果を解析対象ファイル名.csvの名称で出力


・画面右側
  「PBOConsole.exe選択」
     PBOManagerに同梱されているPBOConsole.exeを選択

  「BINToCPP.bat選択」
     「Arma 3 Tools\CfgConvert」に配置されているBINToCPP.batを選択

  「Arma3ConfigExtractor.exe選択」
     下記URLよりダウンロードしたexeを選択
     https://github.com/NYdevelop/Arma3ConfigExtractor/releases

  「StringTable.xmlを取得する」
     チェックすると解析対象PBOを順に解凍し、StringTable.xmlを自動抽出、出力フォルダに配置する
     毎回自動抽出したくない場合、チェックを外して手動パス設定を行う

