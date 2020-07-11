﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mathf = UnityEngine.Mathf;

public static class CameraExtension
{
    static CameraCircleFade camFade(Camera cam)
    {
        CameraCircleFade cf = cam.GetComponent<CameraCircleFade>();
        if (cf) return cf;
        else
        {
            return cam.gameObject.AddComponent<CameraCircleFade>();
        }
    }

    public static void FadeIn(this Camera cam, float duration, Action oncomplete = null, Easing.Type easing = Easing.Type.CubicInOut)
    {
        CameraCircleFade cf = camFade(cam);
        cf.Tween(0f, 1.4f, duration, x => cf.radius = x, easing, oncomplete);
    }

    public static void FadeOut(this Camera cam, float duration, Action oncomplete = null, Easing.Type easing = Easing.Type.CubicInOut)
    {
        CameraCircleFade cf = camFade(cam);
        cf.Tween(1.4f, 0f, duration, x => cf.radius = x, easing, oncomplete);
    }
}

[ExecuteInEditMode]
public class CameraCircleFade : MonoBehaviour
{
    [Range(0f, 1.4f)]
    public float radius;

    float    _radius;
    Material _mtl;

    Material mtl
    {
        get
        {
            if (_mtl) return _mtl;
            else
            {
                _mtl = new Material(Shader.Find("Hidden/Circle"));
                return _mtl;
            }
        }
    }

    void Start()
    {
        if (Application.isEditor && !Application.isPlaying)
        {
            radius = 1.4f;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
        
        if (_radius != radius)
        {
            mtl.SetFloat("_Radius", radius);
            // Debug.Log("Setting radius to " + radius);
            _radius = radius;
        }
    }

    void OnRenderImage(RenderTexture src, RenderTexture dst)
    {
        Graphics.Blit(src, dst, mtl);
    }
}

/* 
 * Functions taken from Tween.js - Licensed under the MIT license
 * at https://github.com/sole/tween.js
 */
public class Easing
{
    public static float Linear(float k)
    {
        return k;
    }

    public class Quadratic
    {
        public static float In(float k)
        {
            return k * k;
        }

        public static float Out(float k)
        {
            return k * (2f - k);
        }

        public static float InOut(float k)
        {
            if ((k *= 2f) < 1f) return 0.5f * k * k;
            return -0.5f * ((k -= 1f) * (k - 2f) - 1f);
        }
    };

    public class Cubic
    {
        public static float In(float k)
        {
            return k * k * k;
        }

        public static float Out(float k)
        {
            return 1f + ((k -= 1f) * k * k);
        }

        public static float InOut(float k)
        {
            if ((k *= 2f) < 1f) return 0.5f * k * k * k;
            return 0.5f * ((k -= 2f) * k * k + 2f);
        }
    };

    public class Quartic
    {
        public static float In(float k)
        {
            return k * k * k * k;
        }

        public static float Out(float k)
        {
            return 1f - ((k -= 1f) * k * k * k);
        }

        public static float InOut(float k)
        {
            if ((k *= 2f) < 1f) return 0.5f * k * k * k * k;
            return -0.5f * ((k -= 2f) * k * k * k - 2f);
        }
    };

    public class Quintic
    {
        public static float In(float k)
        {
            return k * k * k * k * k;
        }

        public static float Out(float k)
        {
            return 1f + ((k -= 1f) * k * k * k * k);
        }

        public static float InOut(float k)
        {
            if ((k *= 2f) < 1f) return 0.5f * k * k * k * k * k;
            return 0.5f * ((k -= 2f) * k * k * k * k + 2f);
        }
    };

    public class Sinusoidal
    {
        public static float In(float k)
        {
            return 1f - Mathf.Cos(k * Mathf.PI / 2f);
        }

        public static float Out(float k)
        {
            return Mathf.Sin(k * Mathf.PI / 2f);
        }

        public static float InOut(float k)
        {
            return 0.5f * (1f - Mathf.Cos(Mathf.PI * k));
        }
    };

    public class Exponential
    {
        public static float In(float k)
        {
            return k == 0f ? 0f : Mathf.Pow(1024f, k - 1f);
        }

        public static float Out(float k)
        {
            return k == 1f ? 1f : 1f - Mathf.Pow(2f, -10f * k);
        }

        public static float InOut(float k)
        {
            if (k         == 0f) return 0f;
            if (k         == 1f) return 1f;
            if ((k *= 2f) < 1f) return 0.5f * Mathf.Pow(1024f, k - 1f);
            return 0.5f * (-Mathf.Pow(2f, -10f * (k - 1f)) + 2f);
        }
    };

    public class Circular
    {
        public static float In(float k)
        {
            return 1f - Mathf.Sqrt(1f - k * k);
        }

        public static float Out(float k)
        {
            return Mathf.Sqrt(1f - ((k -= 1f) * k));
        }

        public static float InOut(float k)
        {
            if ((k *= 2f) < 1f) return -0.5f * (Mathf.Sqrt(1f - k * k) - 1);
            return 0.5f * (Mathf.Sqrt(1f - (k -= 2f) * k) + 1f);
        }
    };

    public class Elastic
    {
        public static float In(float k)
        {
            if (k == 0) return 0;
            if (k == 1) return 1;
            return -Mathf.Pow(2f, 10f * (k -= 1f)) * Mathf.Sin((k - 0.1f) * (2f * Mathf.PI) / 0.4f);
        }

        public static float Out(float k)
        {
            if (k == 0) return 0;
            if (k == 1) return 1;
            return Mathf.Pow(2f, -10f * k) * Mathf.Sin((k - 0.1f) * (2f * Mathf.PI) / 0.4f) + 1f;
        }

        public static float InOut(float k)
        {
            if ((k *= 2f) < 1f) return -0.5f * Mathf.Pow(2f, 10f * (k -= 1f))                       * Mathf.Sin((k - 0.1f) * (2f * Mathf.PI) / 0.4f);
            return Mathf.Pow(2f, -10f * (k -= 1f)) * Mathf.Sin((k - 0.1f) * (2f * Mathf.PI) / 0.4f) * 0.5f + 1f;
        }
    };

    public class Back
    {
        static float s  = 1.70158f;
        static float s2 = 2.5949095f;

        public static float In(float k)
        {
            return k * k * ((s + 1f) * k - s);
        }

        public static float Out(float k)
        {
            return (k -= 1f) * k * ((s + 1f) * k + s) + 1f;
        }

        public static float InOut(float k)
        {
            if ((k *= 2f) < 1f) return 0.5f * (k * k * ((s2 + 1f) * k - s2));
            return 0.5f * ((k -= 2f) * k             * ((s2 + 1f) * k + s2) + 2f);
        }
    };

    public class Bounce
    {
        public static float In(float k)
        {
            return 1f - Out(1f - k);
        }

        public static float Out(float k)
        {
            if (k < (1f / 2.75f))
            {
                return 7.5625f * k * k;
            }
            else if (k < (2f / 2.75f))
            {
                return 7.5625f * (k -= (1.5f / 2.75f)) * k + 0.75f;
            }
            else if (k < (2.5f / 2.75f))
            {
                return 7.5625f * (k -= (2.25f / 2.75f)) * k + 0.9375f;
            }
            else
            {
                return 7.5625f * (k -= (2.625f / 2.75f)) * k + 0.984375f;
            }
        }

        public static float InOut(float k)
        {
            if (k < 0.5f) return In(k * 2f) * 0.5f;
            return Out(k * 2f - 1f)         * 0.5f + 0.5f;
        }
    };

    public enum Type
    {
        Linear = -1,
        QuadraticIn,
        QuadraticOut,
        QuadraticInOut,
        CubicIn,
        CubicOut,
        CubicInOut,
        QuarticIn,
        QuarticOut,
        QuarticInOut,
        SinusoidalIn,
        SinusoidalOut,
        SinusoidalInOut,
        ExponentialIn,
        ExponentialOut,
        ExponentialInOut,
        CircularIn,
        CircularOut,
        CircularInOut,
        ElasticIn,
        ElasticOut,
        ElasticInOut,
        BackIn,
        BackOut,
        BackInOut,
        BounceIn,
        BounceOut,
        BounceInOut,
    }

    public static Dictionary<Type, System.Func<float, float>> interpolation = new Dictionary<Type, System.Func<float, float>>()
    {
        {Type.Linear, Easing.Linear},
        {Type.QuadraticIn, Quadratic.In},
        {Type.QuadraticOut, Quadratic.Out},
        {Type.QuadraticInOut, Quadratic.InOut},
        {Type.CubicIn, Cubic.In},
        {Type.CubicOut, Cubic.Out},
        {Type.CubicInOut, Cubic.InOut},
        {Type.QuarticIn, Quartic.In},
        {Type.QuarticOut, Quartic.Out},
        {Type.QuarticInOut, Quartic.InOut},
        {Type.SinusoidalIn, Sinusoidal.In},
        {Type.SinusoidalOut, Sinusoidal.Out},
        {Type.SinusoidalInOut, Sinusoidal.InOut},
        {Type.ExponentialIn, Exponential.In},
        {Type.ExponentialOut, Exponential.Out},
        {Type.ExponentialInOut, Exponential.InOut},
        {Type.CircularIn, Circular.In},
        {Type.CircularOut, Circular.Out},
        {Type.CircularInOut, Circular.InOut},
        {Type.ElasticIn, Elastic.In},
        {Type.ElasticOut, Elastic.Out},
        {Type.ElasticInOut, Elastic.InOut},
        {Type.BackIn, Back.In},
        {Type.BackOut, Back.Out},
        {Type.BackInOut, Back.InOut},
        {Type.BounceIn, Bounce.In},
        {Type.BounceOut, Bounce.Out},
        {Type.BounceInOut, Bounce.InOut}
    };
}