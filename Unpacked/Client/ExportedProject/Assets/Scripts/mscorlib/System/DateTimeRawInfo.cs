namespace System;

[Token(Token = "0x20000E7")]
internal struct DateTimeRawInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000382")]
	private Int32* num; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000383")]
	internal int numCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000384")]
	internal int month; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000385")]
	internal int year; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000386")]
	internal int dayOfWeek; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000387")]
	internal int era; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000388")]
	internal TM timeMark; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000389")]
	internal double fraction; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400038A")]
	internal bool hasSameDateAndTimeSeparators; //Field offset: 0x28

	[Address(RVA = "0x149A870", Offset = "0x1499A70", Length = "0x13")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000745")]
	internal void AddNumber(int value) { }

	[Address(RVA = "0x149A890", Offset = "0x1499A90", Length = "0xA")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfDSN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetTimeOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetTimeOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetTimeOfN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseISO8601", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeRawInfo&), typeof(__DTString&), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 43)]
	[Token(Token = "0x6000746")]
	internal int GetNumber(int index) { }

	[Address(RVA = "0x149A8A0", Offset = "0x1499AA0", Length = "0x29")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000744")]
	internal void Init(Int32* numberBuffer) { }

}

