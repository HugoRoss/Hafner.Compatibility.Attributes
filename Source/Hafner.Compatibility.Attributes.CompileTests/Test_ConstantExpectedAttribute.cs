// #pragma warning disable CA1857 

namespace Hafner.Compatibility.Attributes.CompileTests;

using System;
using System.Diagnostics.CodeAnalysis;

public static class Test_ConstantExpectedAttribute {

    public static void TestBoolean(bool arg) {
        TakeBooleanConstant(false);
        TakeBooleanConstant(true);
        TakeBooleanConstant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeBooleanConstantWithLimits(false); //CA1857: The constant does not fit within the value bounds of 'True' to 'True'.
        TakeBooleanConstantWithLimits(true);
    }

    public static void TestChar(char arg) {
        TakeCharConstant('A');
        TakeCharConstant('Ж');
        TakeCharConstant('Ð');
        TakeCharConstant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeCharConstantWithLimits('A'); //CA1857: The constant does not fit within the value bounds of 'D' to 'F'.
        TakeCharConstantWithLimits('E');
        TakeCharConstantWithLimits('e'); //CA1857: The constant does not fit within the value bounds of 'D' to 'F'.
        TakeCharConstantWithLimits('H'); //CA1857: The constant does not fit within the value bounds of 'D' to 'F'.
    }

    public static void TestByte(byte arg) {
        TakeByteConstant(0);
        TakeByteConstant(255);
        TakeByteConstant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeByteConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeByteConstantWithLimits(15);
        TakeByteConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestSByte(sbyte arg) {
        TakeSByteConstant(-128);
        TakeSByteConstant(127);
        TakeSByteConstant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeSByteConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeSByteConstantWithLimits(15);
        TakeSByteConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestInt16(short arg) {
        TakeInt16Constant(0);
        TakeInt16Constant(255);
        TakeInt16Constant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeInt16ConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeInt16ConstantWithLimits(15);
        TakeInt16ConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestUInt16(ushort arg) {
        TakeUInt16Constant(0);
        TakeUInt16Constant(65535);
        TakeUInt16Constant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeUInt16ConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeUInt16ConstantWithLimits(15);
        TakeUInt16ConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestInt32(int arg) {
        TakeInt32Constant(0);
        TakeInt32Constant(255);
        TakeInt32Constant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeInt32ConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeInt32ConstantWithLimits(15);
        TakeInt32ConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestUInt32(uint arg) {
        TakeUInt32Constant(0);
        TakeUInt32Constant(65535);
        TakeUInt32Constant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeUInt32ConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeUInt32ConstantWithLimits(15);
        TakeUInt32ConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestInt64(long arg) {
        TakeInt64Constant(0);
        TakeInt64Constant(255);
        TakeInt64Constant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeInt64ConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeInt64ConstantWithLimits(15);
        TakeInt64ConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestUInt64(ulong arg) {
        TakeUInt64Constant(0);
        TakeUInt64Constant(65535);
        TakeUInt64Constant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeUInt64ConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeUInt64ConstantWithLimits(15);
        TakeUInt64ConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestSingle(float arg) {
        TakeSingleConstant(Single.MinValue);
        TakeSingleConstant(Single.MaxValue);
        TakeSingleConstant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeSingleConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeSingleConstantWithLimits(15);
        TakeSingleConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestDouble(double arg) {
        TakeDoubleConstant(Double.MinValue);
        TakeDoubleConstant(3.1415926535897932385);
        TakeDoubleConstant(Double.MaxValue); //CA1857: The argument should be a constant for optimal performance.

        TakeDoubleConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeDoubleConstantWithLimits(15);
        TakeDoubleConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestDouble(ulong arg) {
        TakeDoubleConstant(0);
        TakeDoubleConstant(65535);
        TakeDoubleConstant(arg); //CA1857: The argument should be a constant for optimal performance.

        TakeDoubleConstantWithLimits(5); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
        TakeDoubleConstantWithLimits(15);
        TakeDoubleConstantWithLimits(25); //CA1857: The constant does not fit within the value bounds of '10' to '20'.
    }

    public static void TestDecimal(decimal arg) {
        //Attribute 'ConstantExpected' is not supported (rather surprisingly, as C# does support Decimal constants)!
        TakeDecimalConstant(0);
        TakeDecimalConstant(65535);
        TakeDecimalConstant(arg);

        TakeDecimalConstantWithLimits(5);
        TakeDecimalConstantWithLimits(15);
        TakeDecimalConstantWithLimits(25);
    }


    public static void TestDateTime(DateTime arg) {
        //Attribute 'ConstantExpected' is not supported (not surprisingly, as C# does not support DateTime constants)!
    }


    private static void TakeCharConstant([ConstantExpected] char character) {
        _ = character;
    }

    private static void TakeCharConstantWithLimits([ConstantExpected(Min = 'D', Max = 'F')] char character) {
        _ = character;
    }

    private static void TakeBooleanConstant([ConstantExpected] bool flag) {
        _ = flag;
    }

    private static void TakeBooleanConstantWithLimits([ConstantExpected(Min = true, Max = true)] bool flag) {
        _ = flag;
    }

    private static void TakeByteConstant([ConstantExpected] byte unsignedByte) {
        _ = unsignedByte;
    }

    private static void TakeByteConstantWithLimits([ConstantExpected(Min = 10, Max = 20)] byte unsignedByte) {
        _ = unsignedByte;
    }

    private static void TakeSByteConstant([ConstantExpected] sbyte signedByte) {
        _ = signedByte;
    }

    private static void TakeSByteConstantWithLimits([ConstantExpected(Min = 10, Max = 20)] sbyte signedByte) {
        _ = signedByte;
    }

    private static void TakeInt16Constant([ConstantExpected] short arg) {
        _ = arg;
    }

    private static void TakeInt16ConstantWithLimits([ConstantExpected(Min = 10, Max = 20)] short arg) {
        _ = arg;
    }

    private static void TakeUInt16Constant([ConstantExpected] ushort arg) {
        _ = arg;
    }

    private static void TakeUInt16ConstantWithLimits([ConstantExpected(Min = 10, Max = 20)] ushort arg) {
        _ = arg;
    }

    private static void TakeInt32Constant([ConstantExpected] int arg) {
        _ = arg;
    }

    private static void TakeInt32ConstantWithLimits([ConstantExpected(Min = 10, Max = 20)] int arg) {
        _ = arg;
    }

    private static void TakeUInt32Constant([ConstantExpected] uint arg) {
        _ = arg;
    }

    private static void TakeUInt32ConstantWithLimits([ConstantExpected(Min = 10, Max = 20)] uint arg) {
        _ = arg;
    }

    private static void TakeInt64Constant([ConstantExpected] long arg) {
        _ = arg;
    }

    private static void TakeInt64ConstantWithLimits([ConstantExpected(Min = 10, Max = 20)] long arg) {
        _ = arg;
    }

    private static void TakeUInt64Constant([ConstantExpected] ulong arg) {
        _ = arg;
    }

    private static void TakeUInt64ConstantWithLimits([ConstantExpected(Min = 10, Max = 20)] ulong arg) {
        _ = arg;
    }

    private static void TakeSingleConstant([ConstantExpected] float arg) {
        _ = arg;
    }

    private static void TakeSingleConstantWithLimits([ConstantExpected(Min = 10f, Max = 20f)] float arg) {
        _ = arg;
    }

    private static void TakeDoubleConstant([ConstantExpected] double arg) {
        _ = arg;
    }

    private static void TakeDoubleConstantWithLimits([ConstantExpected(Min = 10.0, Max = 20.0)] double arg) {
        _ = arg;
    }

#pragma warning disable CA1856 // Incorrect usage of ConstantExpected attribute

    private static void TakeDecimalConstant([ConstantExpected] decimal arg) {
        _ = arg;
    }

    private static void TakeDecimalConstantWithLimits([ConstantExpected(Min = 10, Max = 20)] decimal arg) {
        _ = arg;
    }

    private static void TakeDateTimeConstant([ConstantExpected] DateTime arg) {
        _ = arg;
    }

#pragma warning restore CA1856 // Incorrect usage of ConstantExpected attribute

    public static void MyLong1([ConstantExpected] long b) { }
    public static void MyLong2([ConstantExpected(Min = -5, Max = 10)] long b) { }
    public static void MyFloat1([ConstantExpected] float b) { }
    public static void MyFloat2([ConstantExpected(Min = -5.3f, Max = 10.1f)] float b) { }

    // Might want to warn for the negative values and out of range values
#pragma warning disable CA1856 // Incorrect usage of ConstantExpected attribute
    public static void MyInvalidUshort([ConstantExpected(Min = -5, Max = -1)] ushort b) { }
    public static void MyInvalidRange([ConstantExpected(Min = 5, Max = -5)] int b) { }
#pragma warning restore CA1856 // Incorrect usage of ConstantExpected attribute
    // flag any ref type usage as not applicable
    public static void MyString([ConstantExpected] string b) { }

    // Diagnostics examples
    public static void Test(long b, ushort u) {
        // OK
        const long a = 10;
        MyLong1(a);
        MyLong2(a);
        MyLong1(1L);
        MyLong2(2L);
        MyInvalidUshort(1);
        const ushort us = 0;
        MyInvalidUshort(us); // Flag

#pragma warning disable CA1857 // A constant is expected for the parameter
        MyLong1(b); // Flag
#pragma warning restore CA1857 // A constant is expected for the parameter
        MyLong2(b); // Flag


        MyLong2(20); // Flag, out of range
        MyInvalidUshort(u); // Flag
        MyInvalidUshort(10); // Flag, out of the range
    }
}
