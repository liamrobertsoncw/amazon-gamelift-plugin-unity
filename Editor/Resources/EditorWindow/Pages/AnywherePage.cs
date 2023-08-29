﻿// Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0

using UnityEngine.UIElements;

namespace Editor.Resources.EditorWindow.Pages
{
    public class AnywherePage
    {
        private readonly VisualElement _container;

        public AnywherePage(VisualElement container)
        {
            _container = container;
            var mVisualTreeAsset = UnityEngine.Resources.Load<VisualTreeAsset>("EditorWindow/Pages/AnywherePage");
            var uxml = mVisualTreeAsset.Instantiate();

            container.Add(uxml);
            ApplyText();
        }

        private void ApplyText()
        {
            var l = new ElementLocalizer(_container);
            // l.SetElementText("LabelAnywhereIntegrateTitle", "");
        }
    }
}