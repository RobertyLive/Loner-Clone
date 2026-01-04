    The contents are not valid under the current encoding rules.
            
               -or-
            
               The encoded value is too big to fit in a <typeparamref name="TEnum"/> value.
             </exception>
             <exception cref="T:System.ArgumentException">
               <typeparamref name="TEnum"/> is not an enum type.
            
               -or-
            
               <typeparamref name="TEnum"/> was declared with <see cref="T:System.FlagsAttribute"/>.
            
               -or-
            
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagClass"/> is
               <see cref="F:System.Formats.Asn1.TagClass.Universal"/>, but
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagValue"/> is not correct for
               the method.
             </exception>
             <remarks>
               This method does not validate that the return value is defined within
               <typeparamref name="TEnum"/>.
             </remarks>
        </member>
        <member name="M:System.Formats.Asn1.AsnDecoder.ReadEnumeratedValue(System.ReadOnlySpan{System.Byte},System.Formats.Asn1.AsnEncodingRules,System.Type,System.Int32@,System.Nullable{System.Formats.Asn1.Asn1Tag})">
             <summary>
               Reads an Enumerated from <paramref name="source"/> with a specified tag under
               the specified encoding rules, converting it to the
               non-[<see cref="T:System.FlagsAttribute"/>] enum specified by <paramref name="enumType"/>.
             </summary>
             <param name="source">The buffer containing encoded data.</param>
             <param name="ruleSet">The encoding constraints to use when interpreting the data.</param>
             <param name="enumType">Type object representing the destination type.</param>
             <param name="bytesConsumed">
               When this method returns, the total number of bytes for the encoded value.
               This parameter is treated as uninitialized.
             </param>
             <param name="expectedTag">
               The tag to check for before reading, or <see langword="null"/> for the default tag (Universal 10).
             </param>
             <returns>
               The Enumerated value converted to a <paramref name="enumType"/>.
             </returns>
             <exception cref="T:System.Formats.Asn1.AsnContentException">
               The next value does not have the correct tag.
            
               -or-
            
               The length encoding is not valid under the current encoding rules.
            
               -or-
            
               The contents are not valid under the current encoding rules.
            
               -or-
            
               The encoded value is too big to fit in a <paramref name="enumType"/> value.
             </exception>
             <exception cref="T:System.ArgumentException">
               <paramref name="enumType"/> is not an enum type.
            
               -or-
            
               <paramref name="enumType"/> was declared with <see cref="T:System.FlagsAttribute"/>.
            
               -or-
            
               <paramref name="enumType"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagClass"/> is
               <see cref="F:System.Formats.Asn1.TagClass.Universal"/>, but
               <paramref name="enumType"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagValue"/> is not correct for
               the method.
             </exception>
             <exception cref="T:System.ArgumentNullException">
               <paramref name="enumType"/> is <see langword="null" />.
             </exception>
             <remarks>
               This method does not validate that the return value is defined within
               <paramref name="enumType"/>.
             </remarks>
        </member>
        <member name="M:System.Formats.Asn1.AsnDecoder.ReadGeneralizedTime(System.ReadOnlySpan{System.Byte},System.Formats.Asn1.AsnEncodingRules,System.Int32@,System.Nullable{System.Formats.Asn1.Asn1Tag})">
             <summary>
               Reads a GeneralizedTime value from <paramref name="source"/> with a specified tag under
               the specified encoding rules.
             </summary>
             <param name="source">The buffer containing encoded data.</param>
             <param name="ruleSet">The encoding constraints to use when interpreting the data.</param>
             <param name="bytesConsumed">
               When this method returns, the total number of bytes for the encoded value.
               This parameter is treated as uninitialized.
             </param>
             <param name="expectedTag">
               The tag to check for before reading, or <see langword="null"/> for the default tag (Universal 24).
             </param>
             <returns>
               The decoded value.
             </returns>
             <exception cref="T:System.ArgumentOutOfRangeException">
               <paramref name="ruleSet"/> is not defined.
             </exception>
             <exception cref="T:System.Formats.Asn1.AsnContentException">
               The next value does not have the correct tag.
            
               -or-
            
               The length encoding is not valid under the current encoding rules.
            
               -or-
            
               The contents are not valid under the current encoding rules.
             </exception>
             <exception cref="T:System.ArgumentException">
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagClass"/> is
               <see cref="F:System.Formats.Asn1.TagClass.Universal"/>, but
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagValue"/> is not correct for
               the method.
             </exception>
        </member>
        <member name="M:System.Formats.Asn1.AsnDecoder.ReadIntegerBytes(System.ReadOnlySpan{System.Byte},System.Formats.Asn1.AsnEncodingRules,System.Int32@,System.Nullable{System.Formats.Asn1.Asn1Tag})">
             <summary>
               Reads an Integer value from <paramref name="source"/> with a specified tag under
               the specified encoding rules, returning the contents as a slice of the buffer.
             </summary>
             <param name="source">The buffer containing encoded data.</param>
             <param name="ruleSet">The encoding constraints to use when interpreting the data.</param>
             <param name="bytesConsumed">
               When this method returns, the total number of bytes for the encoded value.
               This parameter is treated as uninitialized.
             </param>
             <param name="expectedTag">
               The tag to check for before reading, or <see langword="null"/> for the default tag (Universal 2).
             </param>
             <returns>
               The slice of the buffer containing the bytes of the Integer value, in signed big-endian form.
             </returns>
             <exception cref="T:System.ArgumentOutOfRangeException">
               <paramref name="ruleSet"/> is not defined.
             </exception>
             <exception cref="T:System.Formats.Asn1.AsnContentException">
               The next value does not have the correct tag.
            
               -or-
            
               The length encoding is not valid under the current encoding rules.
            
               -or-
            
               The contents are not valid under the current encoding rules.
             </exception>
             <exception cref="T:System.ArgumentException">
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagClass"/> is
               <see cref="F:System.Formats.Asn1.TagClass.Universal"/>, but
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagValue"/> is not correct for
               the method.
             </exception>
        </member>
        <member name="M:System.Formats.Asn1.AsnDecoder.ReadInteger(System.ReadOnlySpan{System.Byte},System.Formats.Asn1.AsnEncodingRules,System.Int32@,System.Nullable{System.Formats.Asn1.Asn1Tag})">
             <summary>
               Reads an Integer value from <paramref name="source"/> with a specified tag under
               the specified encoding rules.
             </summary>
             <param name="source">The buffer containing encoded data.</param>
             <param name="ruleSet">The encoding constraints to use when interpreting the data.</param>
             <param name="bytesConsumed">
               When this method returns, the total number of bytes for the encoded value.
               This parameter is treated as uninitialized.
             </param>
             <param name="expectedTag">
               The tag to check for before reading, or <see langword="null"/> for the default tag (Universal 2).
             </param>
             <returns>
               The decoded numeric value.
             </returns>
             <exception cref="T:System.ArgumentOutOfRangeException">
               <paramref name="ruleSet"/> is not defined.
             </exception>
             <exception cref="T:System.Formats.Asn1.AsnContentException">
               The next value does not have the correct tag.
            
               -or-
            
               The length encoding is not valid under the current encoding rules.
            
               -or-
            
               The contents are not valid under the current encoding rules.
             </exception>
             <exception cref="T:System.ArgumentException">
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagClass"/> is
               <see cref="F:System.Formats.Asn1.TagClass.Universal"/>, but
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagValue"/> is not correct for
               the method.
             </exception>
        </member>
        <member name="M:System.Formats.Asn1.AsnDecoder.TryReadInt32(System.ReadOnlySpan{System.Byte},System.Formats.Asn1.AsnEncodingRules,System.Int32@,System.Int32@,System.Nullable{System.Formats.Asn1.Asn1Tag})">
             <summary>
               Attempts to read an Integer value from <paramref name="source"/> with a specified tag under
               the specified encoding rules as a signed 32-bit value.
             </summary>
             <param name="source">The buffer containing encoded data.</param>
             <param name="ruleSet">The encoding constraints to use when interpreting the data.</param>
             <param name="value">
               On success, receives the interpreted numeric value.
               This parameter is treated as uninitialized.
             </param>
             <param name="bytesConsumed">
               When this method returns, the total number of bytes for the encoded value.
               This parameter is treated as uninitialized.
             </param>
             <param name="expectedTag">
               The tag to check for before reading, or <see langword="null"/> for the default tag (Universal 2).
             </param>
             <returns>
               <see langword="true"/> if the Integer represents value is between
               <see cref="F:System.Int32.MinValue">Int32.MinValue</see> and <see cref="F:System.Int32.MaxValue">Int32.MaxValue</see>, inclusive; otherwise,
               <see langword="false"/>.
             </returns>
             <exception cref="T:System.ArgumentOutOfRangeException">
               <paramref name="ruleSet"/> is not defined.
             </exception>
             <exception cref="T:System.Formats.Asn1.AsnContentException">
               The next value does not have the correct tag.
            
               -or-
            
               The length encoding is not valid under the current encoding rules.
            
               -or-
            
               The contents are not valid under the current encoding rules.
             </exception>
             <exception cref="T:System.ArgumentException">
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagClass"/> is
               <see cref="F:System.Formats.Asn1.TagClass.Universal"/>, but
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagValue"/> is not correct for
               the method.
             </exception>
        </member>
        <member name="M:System.Formats.Asn1.AsnDecoder.TryReadUInt32(System.ReadOnlySpan{System.Byte},System.Formats.Asn1.AsnEncodingRules,System.UInt32@,System.Int32@,System.Nullable{System.Formats.Asn1.Asn1Tag})">
             <summary>
               Attempts to read an Integer value from <paramref name="source"/> with a specified tag under
               the specified encoding rules as an unsigned 32-bit value.
             </summary>
             <param name="source">The buffer containing encoded data.</param>
             <param name="ruleSet">The encoding constraints to use when interpreting the data.</param>
             <param name="value">
               On success, receives the interpreted numeric value.
               This parameter is treated as uninitialized.
             </param>
             <param name="bytesConsumed">
               When this method returns, the total number of bytes for the encoded value.
               This parameter is treated as uninitialized.
             </param>
             <param name="expectedTag">
               The tag to check for before reading, or <see langword="null"/> for the default tag (Universal 2).
             </param>
             <returns>
               <see langword="true"/> if the Integer represents value is between
               <see cref="F:System.UInt32.MinValue">UInt32.MinValue</see> and <see cref="F:System.UInt32.MaxValue">UInt32.MaxValue</see>, inclusive; otherwise,
               <see langword="false"/>.
             </returns>
             <exception cref="T:System.ArgumentOutOfRangeException">
               <paramref name="ruleSet"/> is not defined.
             </exception>
             <exception cref="T:System.Formats.Asn1.AsnContentException">
               The next value does not have the correct tag.
            
               -or-
            
               The length encoding is not valid under the current encoding rules.
            
               -or-
            
               The contents are not valid under the current encoding rules.
             </exception>
             <exception cref="T:System.ArgumentException">
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagClass"/> is
               <see cref="F:System.Formats.Asn1.TagClass.Universal"/>, but
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagValue"/> is not correct for
               the method.
             </exception>
        </member>
        <member name="M:System.Formats.Asn1.AsnDecoder.TryReadInt64(System.ReadOnlySpan{System.Byte},System.Formats.Asn1.AsnEncodingRules,System.Int64@,System.Int32@,System.Nullable{System.Formats.Asn1.Asn1Tag})">
             <summary>
               Attempts to read an Integer value from <paramref name="source"/> with a specified tag under
               the specified encoding rules as a signed 64-bit value.
             </summary>
             <param name="source">The buffer containing encoded data.</param>
             <param name="ruleSet">The encoding constraints to use when interpreting the data.</param>
             <param name="value">
               On success, receives the interpreted numeric value.
               This parameter is treated as uninitialized.
             </param>
             <param name="bytesConsumed">
               When this method returns, the total number of bytes for the encoded value.
               This parameter is treated as uninitialized.
             </param>
             <param name="expectedTag">
               The tag to check for before reading, or <see langword="null"/> for the default tag (Universal 2).
             </param>
             <returns>
               <see langword="true"/> if the Integer represents value is between
               <see cref="F:System.Int64.MinValue">Int64.MinValue</see> and <see cref="F:System.Int64.MaxValue">Int64.MaxValue</see>, inclusive; otherwise,
               <see langword="false"/>.
             </returns>
             <exception cref="T:System.ArgumentOutOfRangeException">
               <paramref name="ruleSet"/> is not defined.
             </exception>
             <exception cref="T:System.Formats.Asn1.AsnContentException">
               The next value does not have the correct tag.
            
               -or-
            
               The length encoding is not valid under the current encoding rules.
            
               -or-
            
               The contents are not valid under the current encoding rules.
             </exception>
             <exception cref="T:System.ArgumentException">
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagClass"/> is
               <see cref="F:System.Formats.Asn1.TagClass.Universal"/>, but
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagValue"/> is not correct for
               the method.
             </exception>
        </member>
        <member name="M:System.Formats.Asn1.AsnDecoder.TryReadUInt64(System.ReadOnlySpan{System.Byte},System.Formats.Asn1.AsnEncodingRules,System.UInt64@,System.Int32@,System.Nullable{System.Formats.Asn1.Asn1Tag})">
             <summary>
               Attempts to read an Integer value from <paramref name="source"/> with a specified tag under
               the specified encoding rules as an unsigned 64-bit value.
             </summary>
             <param name="source">The buffer containing encoded data.</param>
             <param name="ruleSet">The encoding constraints to use when interpreting the data.</param>
             <param name="value">
               On success, receives the interpreted numeric value.
               This parameter is treated as uninitialized.
             </param>
             <param name="bytesConsumed">
               When this method returns, the total number of bytes for the encoded value.
               This parameter is treated as uninitialized.
             </param>
             <param name="expectedTag">
               The tag to check for before reading, or <see langword="null"/> for the default tag (Universal 2).
             </param>
             <returns>
               <see langword="true"/> if the Integer represents value is between
               <see cref="F:System.UInt64.MinValue">UInt64.MinValue</see> and <see cref="F:System.UInt64.MaxValue">UInt64.MaxValue</see>, inclusive; otherwise,
               <see langword="false"/>.
             </returns>
             <exception cref="T:System.ArgumentOutOfRangeException">
               <paramref name="ruleSet"/> is not defined.
             </exception>
             <exception cref="T:System.Formats.Asn1.AsnContentException">
               The next value does not have the correct tag.
            
               -or-
            
               The length encoding is not valid under the current encoding rules.
            
               -or-
            
               The contents are not valid under the current encoding rules.
             </exception>
             <exception cref="T:System.ArgumentException">
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagClass"/> is
               <see cref="F:System.Formats.Asn1.TagClass.Universal"/>, but
               <paramref name="expectedTag"/>.<see cref="P:System.Formats.Asn1.Asn1Tag.TagValue"/> is not correct for
               the method.
             </exception>
        </member>
        <member name="M:System.Formats.Asn1.AsnDecoder.ReadNamedBitListValue``1(System.ReadOnlySpan{System.Byte},System.Formats.Asn1.AsnEncodingRules,System.Int32@,System.Nullable{System.Formats.Asn1.Asn1Tag})">
             <summary>
               Reads a NamedBitList from <paramref name="source"/> with a specified tag under
               the specified encoding rules, converting it to the
               [<see cref="T:System.FlagsAttribute"/>] enum specified by <typeparamref name="TFlagsEnum"/>.
             </summary>
             <typeparam name="TFlagsEnum">The destination enum type.</typeparam>
             <param name="source">The buffer containing encoded data.</param>
             <param name="ruleSet">The encoding constraints to use when interpreting the data.</param>
             <param name="bytesConsumed">
               When this method returns, the total number of bytes for the encoded value.
               This parameter is treated as uninitialized.
             </param>
             <param name="expectedTag">
               The tag to check for before reading, or <see langword="null"/> for the default tag (Universal 3).
             </param>
             <returns>
               The NamedBitList value converted to a <typeparamref name="TFlagsEnum"/>.
             </returns>
           