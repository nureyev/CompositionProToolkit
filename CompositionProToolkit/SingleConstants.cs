﻿// Copyright (c) 2017 Ratish Philip 
//
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions: 
// 
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software. 
// 
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE. 
//
// This file is part of the CompositionProToolkit project: 
// https://github.com/ratishphilip/CompositionProToolkit
//
// CompositionProToolkit v0.5.1
// 

using System;

namespace CompositionProToolkit
{
    /// <summary>
    /// Class containing some constants
    /// represented as Floating point numbers.
    /// </summary>
    public static class Float
    {
        // Pi related constants
        public const float Pi = (float)Math.PI;
        public const float TwoPi = 2f * Pi;
        public const float PiByTwo = Pi / 2f;
        public const float PiByThree = Pi / 3f;
        public const float PiByFour = Pi / 4f;
        public const float PiBySix = Pi / 6f;
        public const float ThreePiByTwo = 3f * Pi / 2f;

        // Conversion constants        
        public const float DegreeToRadians = Pi / 180f;
        public const float RadiansToDegree = 180f / Pi;
    }
}
