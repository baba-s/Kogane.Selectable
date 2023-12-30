using System;
using System.Collections.Generic;

namespace Kogane
{
    /// <summary>
    /// 読み取り専用の SelectableList
    /// </summary>
    public interface IReadOnlySelectableList<T> : IReadOnlyList<T>
    {
        /// <summary>
        /// 変更された時に呼び出されます
        /// </summary>
        Action OnChange { get; set; }

        /// <summary>
        /// リストの要素を新しい配列にコピーします
        /// </summary>
        T[] ToArray();

        /// <summary>
        /// リストの要素を新しいリストにコピーします
        /// </summary>
        List<T> ToList();
    }
}