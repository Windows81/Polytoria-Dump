namespace System;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20000EA")]
internal struct DateTimeResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003A4")]
	internal int Year; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40003A5")]
	internal int Month; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003A6")]
	internal int Day; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40003A7")]
	internal int Hour; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A8")]
	internal int Minute; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40003A9")]
	internal int Second; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003AA")]
	internal double fraction; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003AB")]
	internal int era; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40003AC")]
	internal ParseFlags flags; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003AD")]
	internal TimeSpan timeZoneOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003AE")]
	internal Calendar calendar; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003AF")]
	internal DateTime parsedDate; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003B0")]
	internal ParseFailureKind failure; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003B1")]
	internal string failureMessageID; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003B2")]
	internal object failureMessageFormatArgument; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003B3")]
	internal string failureArgumentName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003B4")]
	internal ReadOnlySpan<Char> originalDateTimeString; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003B5")]
	internal ReadOnlySpan<Char> failedFormatSpecifier; //Field offset: 0x70

	[Address(RVA = "0x149A8D0", Offset = "0x1499AD0", Length = "0x2B")]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(String[]), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTime&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(String[]), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(TimeSpan&)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Token(Token = "0x6000747")]
	internal void Init(ReadOnlySpan<Char> originalDateTimeString) { }

	[Address(RVA = "0x149A900", Offset = "0x1499B00", Length = "0x45")]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600074B")]
	internal void SetBadDateTimeFailure() { }

	[Address(RVA = "0x149A9A0", Offset = "0x1499BA0", Length = "0x73")]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(String[]), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000749")]
	internal void SetBadFormatSpecifierFailure() { }

	[Address(RVA = "0x149A950", Offset = "0x1499B50", Length = "0x50")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600074A")]
	internal void SetBadFormatSpecifierFailure(ReadOnlySpan<Char> failedFormatSpecifier) { }

	[Address(RVA = "0x58D8C0", Offset = "0x58CAC0", Length = "0xB")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000748")]
	internal void SetDate(int year, int month, int day) { }

	[Address(RVA = "0x149AA50", Offset = "0x1499C50", Length = "0x10")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(String[]), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DateTimeOffsetTimeZonePostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToUniversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseISO8601", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeRawInfo&), typeof(__DTString&), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "CheckDefaultDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(Calendar&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Token(Token = "0x600074C")]
	internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

	[Address(RVA = "0x149AA20", Offset = "0x1499C20", Length = "0xC")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "CheckNewValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(char), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Token(Token = "0x600074D")]
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	[Address(RVA = "0x149AA30", Offset = "0x1499C30", Length = "0x15")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(String[]), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600074E")]
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

}

