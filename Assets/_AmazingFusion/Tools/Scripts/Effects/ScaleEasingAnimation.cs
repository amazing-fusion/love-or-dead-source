﻿using UnityEngine;

namespace com.AmazingFusion {
    public class ScaleEasingAnimation : ValueEasingAnimation {

        protected override void EasingUpdate() {
            base.EasingUpdate();
            float scale = (float)_easingInfo.CurrentValue;
            Transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}