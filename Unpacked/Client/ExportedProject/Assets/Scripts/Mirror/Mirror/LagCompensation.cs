namespace Mirror;

[Token(Token = "0x200001D")]
public static class LagCompensation
{

	[Address(RVA = "0x6E8E50", Offset = "0x6E8050", Length = "0x188")]
	[CalledBy(Type = "Mirror.LagCompensator", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "get_Current", ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>))]
	[Calls(Type = "Mirror.Capture3D", Member = "DrawGizmo", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AA")]
	public static void DrawGizmos(Queue<KeyValuePair`2<Double, T>> history) { }

	[Address(RVA = "0x1250AA0", Offset = "0x124FCA0", Length = "0x11")]
	[CalledBy(Type = "Mirror.LagCompensator", Member = "Sample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), "Mirror.Capture3D&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000A9")]
	public static double EstimateTime(double serverTime, double rtt, double bufferTime) { }

	[Address(RVA = "0x6E9380", Offset = "0x6E8580", Length = "0xF8")]
	[CalledBy(Type = "Mirror.LagCompensator", Member = "Capture", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "Dequeue", ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>))]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "Mirror.Capture3D"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A7")]
	public static void Insert(Queue<KeyValuePair`2<Double, T>> history, int historyLimit, double timestamp, T capture) { }

	[Address(RVA = "0x6E9630", Offset = "0x6E8830", Length = "0x45B")]
	[CalledBy(Type = "Mirror.LagCompensator", Member = "Sample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), "Mirror.Capture3D&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "Peek", ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "get_Current", ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.Capture3D>>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A8")]
	public static bool Sample(Queue<KeyValuePair`2<Double, T>> history, double timestamp, double interval, out T before, out T after, out double t) { }

}

