namespace Unity.Profiling;

[IgnoredByDeepProfiler]
[Token(Token = "0x2000020")]
[UsedByNativeCode]
public struct ProfilerMarker
{
	[IgnoredByDeepProfiler]
	[Token(Token = "0x2000021")]
	[UsedByNativeCode]
	internal struct AutoScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000048")]
		internal readonly IntPtr m_Ptr; //Field offset: 0x0

		[Address(RVA = "0x191E950", Offset = "0x191DB50", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005F")]
		internal AutoScope(IntPtr markerPtr) { }

		[Address(RVA = "0x191E900", Offset = "0x191DB00", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000060")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000047")]
	internal readonly IntPtr m_Ptr; //Field offset: 0x0

	[Address(RVA = "0x1939880", Offset = "0x1938A80", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600005C")]
	public ProfilerMarker(string name) { }

	[Address(RVA = "0x1939850", Offset = "0x1938A50", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600005D")]
	public ProfilerMarker(ProfilerCategory category, string name) { }

	[Address(RVA = "0x1939810", Offset = "0x1938A10", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Pure]
	[Token(Token = "0x600005E")]
	public AutoScope Auto() { }

}

