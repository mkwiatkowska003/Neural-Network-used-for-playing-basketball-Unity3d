﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sigmoid
{
    public static double Output(double x)
    {
        return 1.0 / (1.0 + Mathf.Exp((float)-x));
    }

    public static double Derivative(double x)
    {
        return x * (1 - x);
    }
}
