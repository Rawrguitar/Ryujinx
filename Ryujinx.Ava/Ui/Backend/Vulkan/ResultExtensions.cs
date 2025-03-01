using System;
using Silk.NET.Vulkan;

namespace Ryujinx.Ava.Ui.Vulkan
{
    public static class ResultExtensions
    {
        public static void ThrowOnError(this Result result)
        {
            if (result != Result.Success)
            {
                throw new Exception($"Unexpected API error \"{result}\".");
            }
        }
    }
}
