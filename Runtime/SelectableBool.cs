﻿using System;

namespace Kogane
{
    /// <summary>
    /// 選択中の bool 値を管理するクラス
    /// </summary>
    public sealed class SelectableBool : Selectable<bool>
    {
        /// <summary>
        /// 値が true に変更された時に呼び出されます
        /// </summary>
        public Action OnChangeToTrue { get; set; }

        /// <summary>
        /// 値が false に変更された時に呼び出されます
        /// </summary>
        public Action OnChangeToFalse { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SelectableBool()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SelectableBool( bool value )
        {
            SetValueWithoutCallback( value );
        }

        /// <summary>
        /// 論理否定を実行します
        /// </summary>
        public void Not()
        {
            Value = !Value;
        }

        /// <summary>
        /// true になります
        /// </summary>
        public void True()
        {
            Value = true;
        }

        /// <summary>
        /// false になります
        /// </summary>
        public void False()
        {
            Value = false;
        }

        /// <summary>
        /// 値が変更された時に呼び出されます
        /// </summary>
        protected override void DoOnChanged()
        {
            if ( Value )
            {
                OnChangeToTrue?.Invoke();
            }
            else
            {
                OnChangeToFalse?.Invoke();
            }
        }
    }
}