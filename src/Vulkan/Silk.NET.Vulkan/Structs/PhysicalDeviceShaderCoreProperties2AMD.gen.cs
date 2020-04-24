// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceShaderCoreProperties2AMD
    {
        public PhysicalDeviceShaderCoreProperties2AMD
        (
            StructureType sType = StructureType.PhysicalDeviceShaderCoreProperties2Amd,
            void* pNext = default,
            ShaderCorePropertiesFlagsAMD shaderCoreFeatures = default,
            uint activeComputeUnitCount = default
        )
        {
           SType = sType;
           PNext = pNext;
           ShaderCoreFeatures = shaderCoreFeatures;
           ActiveComputeUnitCount = activeComputeUnitCount;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ShaderCorePropertiesFlagsAMD ShaderCoreFeatures;
/// <summary></summary>
        public uint ActiveComputeUnitCount;
    }
}