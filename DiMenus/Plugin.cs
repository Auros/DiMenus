﻿using IPA;
using SiraUtil;
using SiraUtil.Zenject;
using SiraUtil.Attributes;
using IPALogger = IPA.Logging.Logger;

namespace DiMenus
{
    [Plugin(RuntimeOptions.DynamicInit), Slog]
    public class Plugin
    {
        [Init]
        public Plugin(IPALogger log, Zenjector zenjector)
        {
            zenjector
                .On<PCAppInit>()
                .Pseudo(ctx => ctx.BindLoggerAsSiraLogger(log));
        }

        [OnEnable, OnDisable]
        public void OnState() { /* On State */ }
    }
}