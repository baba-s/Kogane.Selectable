using System;

namespace Kogane
{
    /// <summary>
    /// 読み取り専用の Selectable
    /// </summary>
    public interface IReadOnlySelectable<out T>
    {
        /// <summary>
        /// 値を取得します
        /// </summary>
        T Value { get; }

        /// <summary>
        /// 値が変更された時に呼び出されます
        /// </summary>
        Action OnChange { get; set; }
    }
}