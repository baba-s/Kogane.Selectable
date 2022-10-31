using System;

namespace Kogane
{
    /// <summary>
    /// Selectable 型の拡張メソッド
    /// </summary>
    public static class SelectableExtensionMethods
    {
        /// <summary>
        /// 次の数値に進みます
        /// </summary>
        public static void Next( this Selectable<int> self )
        {
            var value = self.Value + 1;
            self.SetValueIfNotEqual( value );
        }

        /// <summary>
        /// 次の数値に進みます（ループ）
        /// </summary>
        public static void NextLoop( this Selectable<int> self, int max )
        {
            var value = self.Value;
            value = ( value + 1 + max ) % max;
            self.SetValueIfNotEqual( value );
        }

        /// <summary>
        /// 次の数値に進みます
        /// </summary>
        public static void NextClamp( this Selectable<int> self, int max )
        {
            var value = Math.Min( self.Value + 1, max - 1 );
            self.SetValueIfNotEqual( value );
        }

        /// <summary>
        /// 前の数値に戻ります
        /// </summary>
        public static void Prev( this Selectable<int> self )
        {
            var value = self.Value - 1;
            self.SetValueIfNotEqual( value );
        }

        /// <summary>
        /// 前の数値に戻ります（ループ）
        /// </summary>
        public static void PrevLoop( this Selectable<int> self, int max )
        {
            var value = self.Value;
            value = ( value - 1 + max ) % max;
            self.SetValueIfNotEqual( value );
        }

        /// <summary>
        /// 前の数値に戻ります
        /// </summary>
        public static void PrevClamp( this Selectable<int> self, int min )
        {
            var value = Math.Max( self.Value - 1, min );
            self.SetValueIfNotEqual( value );
        }
    }
}