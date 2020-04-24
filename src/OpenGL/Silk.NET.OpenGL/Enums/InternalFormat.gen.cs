// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL
{
    public enum InternalFormat
    {
        StencilIndex = 0x1901,
        StencilIndexOes = 0x1901,
        DepthComponent = 0x1902,
        Red = 0x1903,
        RedExt = 0x1903,
        Rgb = 0x1907,
        Rgba = 0x1908,
        R3G3B2 = 0x2A10,
        Rgb2Ext = 0x804E,
        Rgb4 = 0x804F,
        Rgb4Ext = 0x804F,
        Rgb5 = 0x8050,
        Rgb5Ext = 0x8050,
        Rgb8 = 0x8051,
        Rgb8Ext = 0x8051,
        Rgb8Oes = 0x8051,
        Rgb10 = 0x8052,
        Rgb10Ext = 0x8052,
        Rgb12 = 0x8053,
        Rgb12Ext = 0x8053,
        Rgb16 = 0x8054,
        Rgb16Ext = 0x8054,
        Rgba4 = 0x8056,
        Rgba4Ext = 0x8056,
        Rgba4Oes = 0x8056,
        Rgb5A1 = 0x8057,
        Rgb5A1Ext = 0x8057,
        Rgb5A1Oes = 0x8057,
        Rgba8 = 0x8058,
        Rgba8Ext = 0x8058,
        Rgba8Oes = 0x8058,
        Rgb10A2 = 0x8059,
        Rgb10A2Ext = 0x8059,
        Rgba12 = 0x805A,
        Rgba12Ext = 0x805A,
        Rgba16 = 0x805B,
        Rgba16Ext = 0x805B,
        DualAlpha4Sgis = 0x8110,
        DualAlpha8Sgis = 0x8111,
        DualAlpha12Sgis = 0x8112,
        DualAlpha16Sgis = 0x8113,
        DualLuminance4Sgis = 0x8114,
        DualLuminance8Sgis = 0x8115,
        DualLuminance12Sgis = 0x8116,
        DualLuminance16Sgis = 0x8117,
        DualIntensity4Sgis = 0x8118,
        DualIntensity8Sgis = 0x8119,
        DualIntensity12Sgis = 0x811A,
        DualIntensity16Sgis = 0x811B,
        DualLuminanceAlpha4Sgis = 0x811C,
        DualLuminanceAlpha8Sgis = 0x811D,
        QuadAlpha4Sgis = 0x811E,
        QuadAlpha8Sgis = 0x811F,
        QuadLuminance4Sgis = 0x8120,
        QuadLuminance8Sgis = 0x8121,
        QuadIntensity4Sgis = 0x8122,
        QuadIntensity8Sgis = 0x8123,
        DepthComponent16 = 0x81A5,
        DepthComponent16Arb = 0x81A5,
        DepthComponent16Oes = 0x81A5,
        DepthComponent16Sgix = 0x81A5,
        DepthComponent24Arb = 0x81A6,
        DepthComponent24Oes = 0x81A6,
        DepthComponent24Sgix = 0x81A6,
        DepthComponent32Arb = 0x81A7,
        DepthComponent32Oes = 0x81A7,
        DepthComponent32Sgix = 0x81A7,
        CompressedRed = 0x8225,
        CompressedRG = 0x8226,
        RG = 0x8227,
        R8 = 0x8229,
        R8Ext = 0x8229,
        R16 = 0x822A,
        R16Ext = 0x822A,
        RG8 = 0x822B,
        RG8Ext = 0x822B,
        RG16 = 0x822C,
        RG16Ext = 0x822C,
        R16f = 0x822D,
        R16fExt = 0x822D,
        R32f = 0x822E,
        R32fExt = 0x822E,
        RG16f = 0x822F,
        RG16fExt = 0x822F,
        RG32f = 0x8230,
        RG32fExt = 0x8230,
        R8i = 0x8231,
        R8ui = 0x8232,
        R16i = 0x8233,
        R16ui = 0x8234,
        R32i = 0x8235,
        R32ui = 0x8236,
        RG8i = 0x8237,
        RG8ui = 0x8238,
        RG16i = 0x8239,
        RG16ui = 0x823A,
        RG32i = 0x823B,
        RG32ui = 0x823C,
        CompressedRgbS3TCDxt1Ext = 0x83F0,
        CompressedRgbaS3TCDxt1Ext = 0x83F1,
        CompressedRgbaS3TCDxt3Ext = 0x83F2,
        CompressedRgbaS3TCDxt5Ext = 0x83F3,
        CompressedRgb = 0x84ED,
        CompressedRgba = 0x84EE,
        DepthStencil = 0x84F9,
        DepthStencilExt = 0x84F9,
        DepthStencilNV = 0x84F9,
        DepthStencilOes = 0x84F9,
        DepthStencilMesa = 0x8750,
        Rgba32f = 0x8814,
        Rgba32fArb = 0x8814,
        Rgba32fExt = 0x8814,
        Rgb32f = 0x8815,
        Rgba16f = 0x881A,
        Rgba16fArb = 0x881A,
        Rgba16fExt = 0x881A,
        Rgb16f = 0x881B,
        Rgb16fArb = 0x881B,
        Rgb16fExt = 0x881B,
        Depth24Stencil8 = 0x88F0,
        Depth24Stencil8Ext = 0x88F0,
        Depth24Stencil8Oes = 0x88F0,
        R11fG11fB10f = 0x8C3A,
        R11fG11fB10fApple = 0x8C3A,
        R11fG11fB10fExt = 0x8C3A,
        Rgb9E5 = 0x8C3D,
        Rgb9E5Apple = 0x8C3D,
        Rgb9E5Ext = 0x8C3D,
        Srgb = 0x8C40,
        SrgbExt = 0x8C40,
        Srgb8 = 0x8C41,
        Srgb8Ext = 0x8C41,
        Srgb8NV = 0x8C41,
        SrgbAlpha = 0x8C42,
        SrgbAlphaExt = 0x8C42,
        Srgb8Alpha8 = 0x8C43,
        Srgb8Alpha8Ext = 0x8C43,
        CompressedSrgb = 0x8C48,
        CompressedSrgbAlpha = 0x8C49,
        CompressedSrgbS3TCDxt1Ext = 0x8C4C,
        CompressedSrgbAlphaS3TCDxt1Ext = 0x8C4D,
        CompressedSrgbAlphaS3TCDxt3Ext = 0x8C4E,
        CompressedSrgbAlphaS3TCDxt5Ext = 0x8C4F,
        DepthComponent32f = 0x8CAC,
        Depth32fStencil8 = 0x8CAD,
        StencilIndex1 = 0x8D46,
        StencilIndex1Ext = 0x8D46,
        StencilIndex1Oes = 0x8D46,
        StencilIndex4 = 0x8D47,
        StencilIndex4Ext = 0x8D47,
        StencilIndex4Oes = 0x8D47,
        StencilIndex8 = 0x8D48,
        StencilIndex8Ext = 0x8D48,
        StencilIndex8Oes = 0x8D48,
        StencilIndex16 = 0x8D49,
        StencilIndex16Ext = 0x8D49,
        Rgba32ui = 0x8D70,
        Rgb32ui = 0x8D71,
        Rgba16ui = 0x8D76,
        Rgb16ui = 0x8D77,
        Rgba8ui = 0x8D7C,
        Rgb8ui = 0x8D7D,
        Rgba32i = 0x8D82,
        Rgb32i = 0x8D83,
        Rgba16i = 0x8D88,
        Rgb16i = 0x8D89,
        Rgba8i = 0x8D8E,
        Rgb8i = 0x8D8F,
        DepthComponent32fNV = 0x8DAB,
        Depth32fStencil8NV = 0x8DAC,
        CompressedRedRgtc1 = 0x8DBB,
        CompressedRedRgtc1Ext = 0x8DBB,
        CompressedSignedRedRgtc1 = 0x8DBC,
        CompressedSignedRedRgtc1Ext = 0x8DBC,
        CompressedRGRgtc2 = 0x8DBD,
        CompressedSignedRGRgtc2 = 0x8DBE,
        CompressedRgbaBptcUnorm = 0x8E8C,
        CompressedSrgbAlphaBptcUnorm = 0x8E8D,
        CompressedRgbBptcSignedFloat = 0x8E8E,
        CompressedRgbBptcUnsignedFloat = 0x8E8F,
        R8SNorm = 0x8F94,
        RG8SNorm = 0x8F95,
        Rgb8SNorm = 0x8F96,
        Rgba8SNorm = 0x8F97,
        R16SNorm = 0x8F98,
        R16SNormExt = 0x8F98,
        RG16SNorm = 0x8F99,
        RG16SNormExt = 0x8F99,
        Rgb16SNorm = 0x8F9A,
        Rgb16SNormExt = 0x8F9A,
        Rgb10A2ui = 0x906F,
        CompressedR11Eac = 0x9270,
        CompressedSignedR11Eac = 0x9271,
        CompressedRG11Eac = 0x9272,
        CompressedSignedRG11Eac = 0x9273,
        CompressedRgb8Etc2 = 0x9274,
        CompressedSrgb8Etc2 = 0x9275,
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,
        CompressedRgba8Etc2Eac = 0x9278,
        CompressedSrgb8Alpha8Etc2Eac = 0x9279,
        CompressedRgbaAstc4x4 = 0x93B0,
        CompressedRgbaAstc4x4Khr = 0x93B0,
        CompressedRgbaAstc5x4 = 0x93B1,
        CompressedRgbaAstc5x4Khr = 0x93B1,
        CompressedRgbaAstc5x5 = 0x93B2,
        CompressedRgbaAstc5x5Khr = 0x93B2,
        CompressedRgbaAstc6x5 = 0x93B3,
        CompressedRgbaAstc6x5Khr = 0x93B3,
        CompressedRgbaAstc6x6 = 0x93B4,
        CompressedRgbaAstc6x6Khr = 0x93B4,
        CompressedRgbaAstc8x5 = 0x93B5,
        CompressedRgbaAstc8x5Khr = 0x93B5,
        CompressedRgbaAstc8x6 = 0x93B6,
        CompressedRgbaAstc8x6Khr = 0x93B6,
        CompressedRgbaAstc8x8 = 0x93B7,
        CompressedRgbaAstc8x8Khr = 0x93B7,
        CompressedRgbaAstc10x5 = 0x93B8,
        CompressedRgbaAstc10x5Khr = 0x93B8,
        CompressedRgbaAstc10x6 = 0x93B9,
        CompressedRgbaAstc10x6Khr = 0x93B9,
        CompressedRgbaAstc10x8 = 0x93BA,
        CompressedRgbaAstc10x8Khr = 0x93BA,
        CompressedRgbaAstc10x10 = 0x93BB,
        CompressedRgbaAstc10x10Khr = 0x93BB,
        CompressedRgbaAstc12x10 = 0x93BC,
        CompressedRgbaAstc12x10Khr = 0x93BC,
        CompressedRgbaAstc12x12 = 0x93BD,
        CompressedRgbaAstc12x12Khr = 0x93BD,
        CompressedRgbaAstc3x3x3Oes = 0x93C0,
        CompressedRgbaAstc4x3x3Oes = 0x93C1,
        CompressedRgbaAstc4x4x3Oes = 0x93C2,
        CompressedRgbaAstc4x4x4Oes = 0x93C3,
        CompressedRgbaAstc5x4x4Oes = 0x93C4,
        CompressedRgbaAstc5x5x4Oes = 0x93C5,
        CompressedRgbaAstc5x5x5Oes = 0x93C6,
        CompressedRgbaAstc6x5x5Oes = 0x93C7,
        CompressedRgbaAstc6x6x5Oes = 0x93C8,
        CompressedRgbaAstc6x6x6Oes = 0x93C9,
        CompressedSrgb8Alpha8Astc4x4 = 0x93D0,
        CompressedSrgb8Alpha8Astc4x4Khr = 0x93D0,
        CompressedSrgb8Alpha8Astc5x4 = 0x93D1,
        CompressedSrgb8Alpha8Astc5x4Khr = 0x93D1,
        CompressedSrgb8Alpha8Astc5x5 = 0x93D2,
        CompressedSrgb8Alpha8Astc5x5Khr = 0x93D2,
        CompressedSrgb8Alpha8Astc6x5 = 0x93D3,
        CompressedSrgb8Alpha8Astc6x5Khr = 0x93D3,
        CompressedSrgb8Alpha8Astc6x6 = 0x93D4,
        CompressedSrgb8Alpha8Astc6x6Khr = 0x93D4,
        CompressedSrgb8Alpha8Astc8x5 = 0x93D5,
        CompressedSrgb8Alpha8Astc8x5Khr = 0x93D5,
        CompressedSrgb8Alpha8Astc8x6 = 0x93D6,
        CompressedSrgb8Alpha8Astc8x6Khr = 0x93D6,
        CompressedSrgb8Alpha8Astc8x8 = 0x93D7,
        CompressedSrgb8Alpha8Astc8x8Khr = 0x93D7,
        CompressedSrgb8Alpha8Astc10x5 = 0x93D8,
        CompressedSrgb8Alpha8Astc10x5Khr = 0x93D8,
        CompressedSrgb8Alpha8Astc10x6 = 0x93D9,
        CompressedSrgb8Alpha8Astc10x6Khr = 0x93D9,
        CompressedSrgb8Alpha8Astc10x8 = 0x93DA,
        CompressedSrgb8Alpha8Astc10x8Khr = 0x93DA,
        CompressedSrgb8Alpha8Astc10x10 = 0x93DB,
        CompressedSrgb8Alpha8Astc10x10Khr = 0x93DB,
        CompressedSrgb8Alpha8Astc12x10 = 0x93DC,
        CompressedSrgb8Alpha8Astc12x10Khr = 0x93DC,
        CompressedSrgb8Alpha8Astc12x12 = 0x93DD,
        CompressedSrgb8Alpha8Astc12x12Khr = 0x93DD,
        CompressedSrgb8Alpha8Astc3x3x3Oes = 0x93E0,
        CompressedSrgb8Alpha8Astc4x3x3Oes = 0x93E1,
        CompressedSrgb8Alpha8Astc4x4x3Oes = 0x93E2,
        CompressedSrgb8Alpha8Astc4x4x4Oes = 0x93E3,
        CompressedSrgb8Alpha8Astc5x4x4Oes = 0x93E4,
        CompressedSrgb8Alpha8Astc5x5x4Oes = 0x93E5,
        CompressedSrgb8Alpha8Astc5x5x5Oes = 0x93E6,
        CompressedSrgb8Alpha8Astc6x5x5Oes = 0x93E7,
        CompressedSrgb8Alpha8Astc6x6x5Oes = 0x93E8,
        CompressedSrgb8Alpha8Astc6x6x6Oes = 0x93E9,
    }
}