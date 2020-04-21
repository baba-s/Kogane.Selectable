# Uni Selectable

値が変更された時にコールバックが呼び出されるクラス

## 使用例

```cs
using UniSelectable;
using UnityEngine;

public class Example : MonoBehaviour
{
	private readonly Selectable<int> m_value = new Selectable<int>();

	private void Start()
	{
		// 値が変更された時に呼び出されるコールバック関数を登録します
		m_value.OnChange += () => Debug.Log( m_value.Value );

		// 値を変更します（コールバック関数が呼び出されます）
		m_value.Value = 100;

		// 値を変更します（値が変わらないのでコールバック関数は呼び出されません）
		m_value.SetValueIfNotEqual( 100 );

		// 値を変更します（値が変わるのでコールバック関数が呼び出されます）
		m_value.SetValueIfNotEqual( 200 );

		// 値を変更します（コールバック関数は呼び出されません）
		m_value.SetValueWithoutCallback( 300 );
	}
}
```

```cs
using UniSelectable;
using UnityEngine;

public class Example : MonoBehaviour
{
	private readonly SelectableList<int> m_list = new SelectableList<int>();

	private void Start()
	{
		// リストが変更された時に呼び出されるコールバック関数を登録します
		m_list.OnChange += () => Debug.Log( string.Join( ", ", m_list ) );

		// リストに要素を挿入します
		m_list.Insert( 0, 1 );
		m_list.Insert( 0, 2 );
		m_list.Insert( 0, 3 );

		// リストから要素を削除します
		m_list.RemoveAt( 0 );
		m_list.RemoveAt( 0 );
		m_list.RemoveAt( 0 );

		// リストに要素を追加します
		m_list.Add( 4 );
		m_list.Add( 5 );
		m_list.Add( 6 );

		// リストの要素を全削除します
		m_list.Clear();
	}
}
```

## 関連記事

* http://baba-s.hatenablog.com/entry/2016/03/07/100000
* http://baba-s.hatenablog.com/entry/2016/03/08/100000
