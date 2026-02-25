namespace System.Globalization;

[Token(Token = "0x2000549")]
internal static class TimeSpanParse
{
	[Token(Token = "0x200054A")]
	private enum ParseFailureKind
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		Overflow = 4,
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	[Token(Token = "0x200054F")]
	private struct TimeSpanRawInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400160F")]
		internal TTT _lastSeenTTT; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001610")]
		internal int _tokenCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001611")]
		internal int _sepCount; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4001612")]
		internal int _numCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001613")]
		private FormatLiterals _posLoc; //Field offset: 0x10
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001614")]
		private FormatLiterals _negLoc; //Field offset: 0x38
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4001615")]
		private bool _posLocInit; //Field offset: 0x60
		[FieldOffset(Offset = "0x61")]
		[Token(Token = "0x4001616")]
		private bool _negLocInit; //Field offset: 0x61
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4001617")]
		private string _fullPosPattern; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4001618")]
		private string _fullNegPattern; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4001619")]
		internal TimeSpanToken _numbers0; //Field offset: 0x78
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400161A")]
		internal TimeSpanToken _numbers1; //Field offset: 0x98
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400161B")]
		internal TimeSpanToken _numbers2; //Field offset: 0xB8
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x400161C")]
		internal TimeSpanToken _numbers3; //Field offset: 0xD8
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x400161D")]
		internal TimeSpanToken _numbers4; //Field offset: 0xF8
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x400161E")]
		internal ReadOnlySpan<Char> _literals0; //Field offset: 0x118
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x400161F")]
		internal ReadOnlySpan<Char> _literals1; //Field offset: 0x128
		[FieldOffset(Offset = "0x138")]
		[Token(Token = "0x4001620")]
		internal ReadOnlySpan<Char> _literals2; //Field offset: 0x138
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x4001621")]
		internal ReadOnlySpan<Char> _literals3; //Field offset: 0x148
		[FieldOffset(Offset = "0x158")]
		[Token(Token = "0x4001622")]
		internal ReadOnlySpan<Char> _literals4; //Field offset: 0x158
		[FieldOffset(Offset = "0x168")]
		[Token(Token = "0x4001623")]
		internal ReadOnlySpan<Char> _literals5; //Field offset: 0x168

		[Token(Token = "0x17000587")]
		internal FormatLiterals NegativeInvariant
		{
			[Address(RVA = "0x14055F0", Offset = "0x14047F0", Length = "0x6D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Token(Token = "0x6002631")]
			internal get { } //Length: 109
		}

		[Token(Token = "0x17000589")]
		internal FormatLiterals NegativeLocalized
		{
			[Address(RVA = "0x1405660", Offset = "0x1404860", Length = "0xC6")]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
			[Calls(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
			[Token(Token = "0x6002633")]
			internal get { } //Length: 198
		}

		[Token(Token = "0x17000586")]
		internal FormatLiterals PositiveInvariant
		{
			[Address(RVA = "0x1405730", Offset = "0x1404930", Length = "0x6C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Token(Token = "0x6002630")]
			internal get { } //Length: 108
		}

		[Token(Token = "0x17000588")]
		internal FormatLiterals PositiveLocalized
		{
			[Address(RVA = "0x14057A0", Offset = "0x14049A0", Length = "0xC6")]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
			[Calls(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
			[Token(Token = "0x6002632")]
			internal get { } //Length: 198
		}

		[Address(RVA = "0x1403940", Offset = "0x1402B40", Length = "0x14B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "System.Globalization.TimeSpanParse+TimeSpanResult", Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+ParseFailureKind", typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6002640")]
		private bool AddNum(TimeSpanToken num, ref TimeSpanResult result) { }

		[Address(RVA = "0x1403A90", Offset = "0x1402C90", Length = "0x148")]
		[CalledBy(Type = typeof(TimeSpanRawInfo), Member = "ProcessToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanToken&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "System.Globalization.TimeSpanParse+TimeSpanResult", Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+ParseFailureKind", typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600263F")]
		private bool AddSep(ReadOnlySpan<Char> sep, ref TimeSpanResult result) { }

		[Address(RVA = "0x1403BE0", Offset = "0x1402DE0", Length = "0x2FE")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002634")]
		internal bool FullAppCompatMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1403EE0", Offset = "0x14030E0", Length = "0x27C")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002639")]
		internal bool FullDHMMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1404160", Offset = "0x1403360", Length = "0x302")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600263B")]
		internal bool FullDHMSMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1404470", Offset = "0x1403670", Length = "0x17A")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002637")]
		internal bool FullDMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x14045F0", Offset = "0x14037F0", Length = "0x1F2")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002638")]
		internal bool FullHMMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x14047F0", Offset = "0x14039F0", Length = "0x302")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600263C")]
		internal bool FullHMSFMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1404B00", Offset = "0x1403D00", Length = "0x27C")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600263A")]
		internal bool FullHMSMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1404D80", Offset = "0x1403F80", Length = "0x388")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002636")]
		internal bool FullMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x14055F0", Offset = "0x14047F0", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002631")]
		internal FormatLiterals get_NegativeInvariant() { }

		[Address(RVA = "0x1405660", Offset = "0x1404860", Length = "0xC6")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002633")]
		internal FormatLiterals get_NegativeLocalized() { }

		[Address(RVA = "0x1405730", Offset = "0x1404930", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002630")]
		internal FormatLiterals get_PositiveInvariant() { }

		[Address(RVA = "0x14057A0", Offset = "0x14049A0", Length = "0xC6")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002632")]
		internal FormatLiterals get_PositiveLocalized() { }

		[Address(RVA = "0x1405110", Offset = "0x1404310", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600263D")]
		internal void Init(DateTimeFormatInfo dtfi) { }

		[Address(RVA = "0x1405170", Offset = "0x1404370", Length = "0x278")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002635")]
		internal bool PartialAppCompatMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x14053F0", Offset = "0x14045F0", Length = "0x1FD")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "System.Globalization.TimeSpanParse+TimeSpanResult", Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+ParseFailureKind", typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TimeSpanRawInfo), Member = "AddSep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600263E")]
		internal bool ProcessToken(ref TimeSpanToken tok, ref TimeSpanResult result) { }

	}

	[Token(Token = "0x2000550")]
	private struct TimeSpanResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001624")]
		internal TimeSpan parsedTimeSpan; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001625")]
		private readonly bool _throwOnFailure; //Field offset: 0x8

		[Address(RVA = "0x14059E0", Offset = "0x1404BE0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002641")]
		internal TimeSpanResult(bool throwOnFailure) { }

		[Address(RVA = "0x1405870", Offset = "0x1404A70", Length = "0x162")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "AddNum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+TimeSpanToken", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "AddSep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "ProcessToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanToken&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 20)]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002642")]
		internal bool SetFailure(ParseFailureKind kind, string resourceKey, object messageArgument = null, string argumentName = null) { }

	}

	[Flags]
	[Token(Token = "0x200054B")]
	private enum TimeSpanStandardStyles
	{
		None = 0,
		Invariant = 1,
		Localized = 2,
		RequireFull = 4,
		Any = 3,
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	[Token(Token = "0x200054D")]
	private struct TimeSpanToken
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001609")]
		internal TTT _ttt; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400160A")]
		internal int _num; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400160B")]
		internal int _zeroes; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400160C")]
		internal ReadOnlySpan<Char> _sep; //Field offset: 0x10

		[Address(RVA = "0x1405A50", Offset = "0x1404C50", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002629")]
		public TimeSpanToken(TTT type) { }

		[Address(RVA = "0x1405A80", Offset = "0x1404C80", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600262A")]
		public TimeSpanToken(int number) { }

		[Address(RVA = "0x1405A60", Offset = "0x1404C60", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600262B")]
		public TimeSpanToken(TTT type, int number, int leadingZeroes, ReadOnlySpan<Char> separator) { }

		[Address(RVA = "0x14059F0", Offset = "0x1404BF0", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600262C")]
		public bool IsInvalidFraction() { }

	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	[Token(Token = "0x200054E")]
	private struct TimeSpanTokenizer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400160D")]
		private ReadOnlySpan<Char> _value; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400160E")]
		private int _pos; //Field offset: 0x10

		[Address(RVA = "0x1405CF0", Offset = "0x1404EF0", Length = "0xE")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600262D")]
		internal TimeSpanTokenizer(ReadOnlySpan<Char> input) { }

		[Address(RVA = "0x88C310", Offset = "0x88B510", Length = "0xB")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600262E")]
		internal TimeSpanTokenizer(ReadOnlySpan<Char> input, int startPosition) { }

		[Address(RVA = "0x1405AA0", Offset = "0x1404CA0", Length = "0x24B")]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600262F")]
		internal TimeSpanToken GetNextToken() { }

	}

	[Token(Token = "0x200054C")]
	private enum TTT
	{
		None = 0,
		End = 1,
		Num = 2,
		Sep = 3,
		NumOverflow = 4,
	}


	[Address(RVA = "0x13FE490", Offset = "0x13FD690", Length = "0x40")]
	[CalledBy(Type = typeof(TimeSpan), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeSpan), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStandardStyles), typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002621")]
	internal static TimeSpan Parse(ReadOnlySpan<Char> input, IFormatProvider formatProvider) { }

	[Address(RVA = "0x13FE4D0", Offset = "0x13FD6D0", Length = "0x34")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseFractionExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(Double&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(Pattern)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeSpanToken), Member = "IsInvalidFraction", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryTimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(TimeSpanToken), typeof(TimeSpanToken), typeof(TimeSpanToken), typeof(TimeSpanToken), typeof(TimeSpanToken), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600261F")]
	internal static long Pow10(int pow) { }

	[Address(RVA = "0x13FEB60", Offset = "0x13FDD60", Length = "0x330")]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullDMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002628")]
	private static bool ProcessTerminal_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x13FE720", Offset = "0x13FD920", Length = "0x43F")]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStandardStyles), typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002624")]
	private static bool ProcessTerminal_DHMSF(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x14021C0", Offset = "0x14013C0", Length = "0x35D")]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullHMMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002627")]
	private static bool ProcessTerminal_HM(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x1400A50", Offset = "0x13FFC50", Length = "0x176B")]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStandardStyles), typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullHMSMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullDHMMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "PartialAppCompatMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002626")]
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x13FEE90", Offset = "0x13FE090", Length = "0x1BBB")]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStandardStyles), typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullHMSFMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullDHMSMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullAppCompatMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002625")]
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x13FE5C0", Offset = "0x13FD7C0", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "ProcessToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanToken&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6002623")]
	private static bool ProcessTerminalState(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x1402520", Offset = "0x1401720", Length = "0x1252")]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpanTokenizer), Member = "GetNextToken", ReturnType = typeof(TimeSpanToken))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "ProcessToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanToken&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(MemoryExtensions), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002622")]
	private static bool TryParseTimeSpan(ReadOnlySpan<Char> input, TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanResult result) { }

	[Address(RVA = "0x1403780", Offset = "0x1402980", Length = "0x1C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002620")]
	private static bool TryTimeToTicks(bool positive, TimeSpanToken days, TimeSpanToken hours, TimeSpanToken minutes, TimeSpanToken seconds, TimeSpanToken fraction, out long result) { }

}

