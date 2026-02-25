namespace Mirror;

[Token(Token = "0x2000076")]
public static class SnapshotInterpolation
{

	[Address(RVA = "0x12A3130", Offset = "0x12A2330", Length = "0x13")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTimeSnapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshot)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = "OnTimeSnapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshot)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003EE")]
	public static double DynamicAdjustment(double sendInterval, double jitterStandardDeviation, double dynamicAdjustmentTolerance) { }

	[Address(RVA = "0x75AB10", Offset = "0x759D10", Length = "0x24D")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTimeSnapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshot)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = "OnTimeSnapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshot)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TimeSnapshot>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(TimeSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B110")]
	[Calls(Type = typeof(ExponentialMovingAverage), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "TimelineClamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "Timescale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F1")]
	public static void InsertAndAdjust(SortedList<Double, T> buffer, int bufferLimit, T snapshot, ref double localTimeline, ref double localTimescale, float sendInterval, double bufferTime, double catchupSpeed, double slowdownSpeed, ref ExponentialMovingAverage driftEma, float catchupNegativeThreshold, float catchupPositiveThreshold, ref ExponentialMovingAverage deliveryTimeEma) { }

	[Address(RVA = "0x75AF40", Offset = "0x75A140", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TimeSnapshot>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(TimeSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EF")]
	public static bool InsertIfNotExists(SortedList<Double, T> buffer, int bufferLimit, T snapshot) { }

	[Address(RVA = "0x75B6D0", Offset = "0x75A8D0", Length = "0x342")]
	[CalledBy(Type = typeof(SnapshotInterpolation), Member = "StepInterpolation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(double), "T&", "T&", typeof(Double&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F2")]
	public static void Sample(SortedList<Double, T> buffer, double localTimeline, out int from, out int to, out double t) { }

	[Address(RVA = "0x75C2E0", Offset = "0x75B4E0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F5")]
	public static void Step(SortedList<Double, T> buffer, double deltaTime, ref double localTimeline, double localTimescale, out T fromSnapshot, out T toSnapshot, out double t) { }

	[Address(RVA = "0x75BE60", Offset = "0x75B060", Length = "0x288")]
	[CalledBy(Type = typeof(NetworkClient), Member = "NetworkEarlyUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "UpdateTimeInterpolation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = "UpdateTimeInterpolation", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "Sample", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(double), typeof(Int32&), typeof(Int32&), typeof(Double&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(SortedList`2), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F4")]
	public static void StepInterpolation(SortedList<Double, T> buffer, double localTimeline, out T fromSnapshot, out T toSnapshot, out double t) { }

	[Address(RVA = "0x12A3150", Offset = "0x12A2350", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003F3")]
	public static void StepTime(double deltaTime, ref double localTimeline, double localTimescale) { }

	[Address(RVA = "0x12A3160", Offset = "0x12A2360", Length = "0x23")]
	[CalledBy(Type = typeof(SnapshotInterpolation), Member = "InsertAndAdjust", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(int), "T", typeof(Double&), typeof(Double&), typeof(float), typeof(double), typeof(double), typeof(double), typeof(ExponentialMovingAverage&), typeof(float), typeof(float), typeof(ExponentialMovingAverage&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003F0")]
	public static double TimelineClamp(double localTimeline, double bufferTime, double latestRemoteTime) { }

	[Address(RVA = "0x12A3190", Offset = "0x12A2390", Length = "0x27")]
	[CalledBy(Type = typeof(SnapshotInterpolation), Member = "InsertAndAdjust", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(int), "T", typeof(Double&), typeof(Double&), typeof(float), typeof(double), typeof(double), typeof(double), typeof(ExponentialMovingAverage&), typeof(float), typeof(float), typeof(ExponentialMovingAverage&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003ED")]
	public static double Timescale(double drift, double catchupSpeed, double slowdownSpeed, double absoluteCatchupNegativeThreshold, double absoluteCatchupPositiveThreshold) { }

}

