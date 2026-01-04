照してください)。および<see cref="P:System.Text.Encoding.EncoderFallback" /> が <see cref="T:System.Text.EncoderExceptionFallback" /> に設定されます。</exception>
      <filterpriority>1</filterpriority>
    </member>
    <member name="M:System.Text.Encoding.GetCharCount(System.Byte*,System.Int32)">
      <summary>派生クラスでオーバーライドされた場合、指定したバイト ポインターから始まるバイト シーケンスをデコードすることによって生成される文字数を計算します。</summary>
      <returns>指定したバイト シーケンスをデコードすることによって生成される文字数。</returns>
      <param name="bytes">デコードする最初のバイトへのポインター。</param>
      <param name="count">デコードするバイト数。</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="bytes" /> は null です。 </exception>
      <exception cref="T:System.ArgumentOutOfRangeException">
        <paramref name="count" /> が 0 未満です。</exception>
      <exception cref="T:System.Text.DecoderFallbackException">フォールバックが発生しました (詳細については、「.NET Framework における文字エンコーディング」を参照してください)。および<see cref="P:System.Text.Encoding.DecoderFallback" /> が <see cref="T:System.Text.DecoderExceptionFallback" /> に設定されます。</exception>
      <filterpriority>1</filterpriority>
    </member>
    <member name="M:System.Text.Encoding.GetCharCount(System.Byte[])">
      <summary>派生クラスでオーバーライドされた場合、指定したバイト配列に格納されているすべてのバイトをデコードすることによって生成される文字数を計算します。</summary>
      <returns>指定したバイト シーケンスをデコードすることによって生成される文字数。</returns>
      <param name="bytes">デコード対象のバイト シーケンスが格納されたバイト配列。</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="bytes" /> は null です。</exception>
      <exception cref="T:System.Text.DecoderFallbackException">フォールバックが発生しました (詳細については、「.NET Framework における文字エンコーディング」を参照してください)。および<see cref="P:System.Text.Encoding.DecoderFallback" /> が <see cref="T:System.Text.DecoderExceptionFallback" /> に設定されます。</exception>
      <filterpriority>1</filterpriority>
    </member>
    <member name="M:System.Text.Encoding.GetCharCount(System.Byte[],System.Int32,System.Int32)">
      <summary>派生クラスでオーバーライドされた場合、指定したバイト配列に格納されているバイト シーケンスをデコードすることによって生成される文字数を計算します。</summary>
      <returns>指定したバイト シーケンスをデコードすることによって生成される文字数。</returns>
      <param name="bytes">デコード対象のバイト シーケンスが格納されたバイト配列。</param>
      <param name="index">デコードする最初のバイトのインデックス。</param>
      <param name="count">デコードするバイト数。</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="bytes" /> は null です。 </exception>
      <exception cref="T:System.ArgumentOutOfRangeException">
        <paramref name="index" /> または <paramref name="count" /> が 0 未満です。または <paramref name="index" /> および <paramref name="count" /> が <paramref name="bytes" /> 内の有効な範囲を示していません。</exception>
      <exception cref="T:System.Text.DecoderFallbackException">フォールバックが発生しました (詳細については、「.NET Framework における文字エンコーディング」を参照してください)。および<see cref="P:System.Text.Encoding.DecoderFallback" /> が <see cref="T:System.Text.DecoderExceptionFallback" /> に設定されます。</exception>
      <filterpriority>1</filterpriority>
    </member>
    <member name="M:System.Text.Encoding.GetChars(System.Byte*,System.Int32,System.Char*,System.Int32)">
      <summary>派生クラスでオーバーライドされた場合、指定したバイト ポインターで始まるバイト シーケンスを、指定した文字ポインターを開始位置として格納される文字のセットにデコードします。</summary>
      <returns>
        <paramref name="chars" /> パラメーターによって示される位置に書き込まれた実際の文字数。</returns>
      <param name="bytes">デコードする最初のバイトへのポインター。</param>
      <param name="byteCount">デコードするバイト数。</param>
      <param name="chars">結果の文字セットの書き込みを開始する位置へのポインター。</param>
      <param name="charCount">書き込む文字の最大数。</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="bytes" /> は null です。または <paramref name="chars" /> は null です。 </exception>
      <exception cref="T:System.ArgumentOutOfRangeException">
        <paramref name="byteCount" /> または <paramref name="charCount" /> が 0 未満です。 </exception>
      <exception cref="T:System.ArgumentException">
        <paramref name="charCount" /> が結果の文字数より少なくなっています。</exception>
      <exception cref="T:System.Text.DecoderFallbackException">フォールバックが発生しました (詳細については、「.NET Framework における文字エンコーディング」を参照してください)。および<see cref="P:System.Text.Encoding.DecoderFallback" /> が <see cref="T:System.Text.DecoderExceptionFallback" /> に設定されます。</exception>
      <filterpriority>1</filterpriority>
    </member>
    <member name="M:System.Text.Encoding.GetChars(System.Byte[])">
      <summary>派生クラスでオーバーライドされた場合、指定したバイト配列に格納されているすべてのバイトを文字のセットにデコードします。</summary>
      <returns>指定したバイト シーケンスのデコード結果が格納された文字配列。</returns>
      <param name="bytes">デコード対象のバイト シーケンスが格納されたバイト配列。</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="bytes" /> は null です。</exception>
      <exception cref="T:System.Text.DecoderFallbackException">フォールバックが発生しました (詳細については、「.NET Framework における文字エンコーディング」を参照してください)。および<see cref="P:System.Text.Encoding.DecoderFallback" /> が <see cref="T:System.Text.DecoderExceptionFallback" /> に設定されます。</exception>
      <filterpriority>1</filterpriority>
    </member>
    <member name="M:System.Text.Encoding.GetChars(System.Byte[],System.Int32,System.Int32)">
      <summary>派生クラスでオーバーライドされた場合、指定したバイト配列に格納されているバイト シーケンスを文字のセットにデコードします。</summary>
      <returns>指定したバイト シーケンスのデコード結果が格納された文字配列。</returns>
      <param name="bytes">デコード対象のバイト シーケンスが格納されたバイト配列。</param>
      <param name="index">デコードする最初のバイトのインデックス。</param>
      <param name="count">デコードするバイト数。</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="bytes" /> は null です。 </exception>
      <exception cref="T:System.ArgumentOutOfRangeException">
        <paramref name="index" /> または <paramref name="count" /> が 0 未満です。または <paramref name="index" /> および <paramref name="count" /> が <paramref name="bytes" /> 内の有効な範囲を示していません。</exception>
      <exception cref="T:System.Text.DecoderFallbackException">フォールバックが発生しました (詳細については、「.NET Framework における文字エンコーディング」を参照してください)。および<see cref="P:System.Text.Encoding.DecoderFallback" /> が <see cref="T:System.Text.DecoderExceptionFallback" /> に設定されます。</exception>
      <filterpriority>1</filterpriority>
    </member>
    <member name="M:System.Text.Encoding.GetChars(System.Byte[],System.Int32,System.Int32,System.Char[],System.Int32)">
      <summary>派生クラスでオーバーライドされた場合、指定したバイト配列に格納されているバイト シーケンスを、指定した文字配列にデコードします。</summary>
      <returns>
        <paramref name="chars" /> に書き込まれた実際の文字数。</returns>
      <param name="bytes">デコード対象のバイト シーケンスが格納されたバイト配列。</param>
      <param name="byteIndex">デコードする最初のバイトのインデックス。</param>
      <param name="byteCount">デコードするバイト数。</param>
      <param name="chars">結果の文字のセットを格納する文字配列。</param>
      <param name="charIndex">結果の文字のセットを書き込む開始位置のインデックス。</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="bytes" /> は null です。または <paramref name="chars" /> は null です。 </exception>
      <exception cref="T:System.ArgumentOutOfRangeException">
        <paramref name="byteIndex" />、<paramref name="byteCount" />、または <paramref name="charIndex" /> が 0 未満です。または <paramref name="byteindex" /> および <paramref name="byteCount" /> が <paramref name="bytes" /> 内の有効な範囲を示していません。または <paramref name="charIndex" /> が <paramref name="chars" /> の有効なインデックスではありません。 </exception>
      <exception cref="T:System.ArgumentException">
        <paramref name="chars" /> には、<paramref name="charIndex" /> から配列の末尾までに十分なサイズがなく、結果の文字を格納できません。</exception>
      <exception cref="T:System.Text.DecoderFallbackException">フォールバックが発生しました (詳細については、「.NET Framework における文字エンコーディング」を参照してください)。および<see cref="P:System.Text.Encoding.DecoderFallback" /> が <see cref="T:System.Text.DecoderExceptionFallback" /> に設定されます。</exception>
      <filterpriority>1</filterpriority>
    </member>
    <member name="M:System.Text.Encoding.GetDecoder">
      <summary>派生クラスでオーバーライドされた場合、エンコード済みバイト シーケンスを文字シーケンスに変換するデコーダーを取得します。</summary>
      <returns>エンコード済みバイト シーケンスを文字シーケンスに変換する <see cref="T:System.Text.Decoder" />。</returns>
      <filterpriority>1</filterpriority>
    </member>
    <member name="M:System.Text.Encoding.GetEncoder">
      <summary>派生クラスでオーバーライドされた場合、Unicode 文字のシーケンスをエンコード済みバイト シーケンスに変換するエンコーダーを取得します。</summary>
      <returns>Unicode 文字のシーケンスをエンコード済みバイト シーケンスに変換する <see cref="T:System.Text.Encoder" />。</returns>
      <filterpriority>1</filterpriority>
    </member>
    <member name="M:System.Text.Encoding.GetEncoding(System.Int32)">
      <summary>指定したコード ページ ID に関連付けられたエンコーディングを返します。</summary>
      <returns>指定したコード ペ�