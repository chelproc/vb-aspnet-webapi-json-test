# ASP.NET (.NET Framerwork) Web API (JSON利用)

## 要件

* ASP.NET (.NET Framerwork) Web API 2 を利用する (.NET Coreは使用しない)
* HTTP POSTリクエストのボディにJSONを受け取り、JSONを返却するWeb APIを提供
* リクエストボディのバリデーション

## 概要

`/api/todos/add`に対しPOSTリクエスト

### リクエストボディのサンプル
```json
{
  "todos": [
    {
      "title": "野菜を買う",
      "asignee": "鈴木 一郎"
    },
    {
      "title": "米を買う",
      "asignee": "佐藤 次郎"
    }
  ]
}
```

スキーマ:
```json
{
  "type": "object",
  "required": [
    "todos"
  ],
  "properties": {
    "todos": {
      "type": "array",
      "items": {
        "type": "object",
        "required": [
          "title",
          "asignee"
        ],
        "properties": {
          "title": {
            "type": "string",
          },
          "asignee": {
            "type": "string",
            "pattern": "\\S+ \\S+"
          }
        }
      },
      "minItems": 1
    }
  }
}
```

### レスポンス
```json
{
  "status": "success",
  "count": 2
}
```

## 参考
* ASP.NET Web APIの概要: https://www.atmarkit.co.jp/ait/subtop/features/dotnet/aspwebapi_index.html
* 属性ベースのルーティング: https://docs.microsoft.com/ja-jp/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
* リクエストのバリデーション周り: https://docs.microsoft.com/ja-jp/aspnet/web-api/overview/formats-and-model-binding/model-validation-in-aspnet-web-api