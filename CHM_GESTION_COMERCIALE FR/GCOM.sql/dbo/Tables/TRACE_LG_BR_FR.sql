﻿CREATE TABLE [dbo].[TRACE_LG_BR_FR] (
    [ORDRE]          DECIMAL (18)    NOT NULL,
    [CODE_BRECEP]    DECIMAL (18)    CONSTRAINT [DF_TRACE_LG_BR_FR_CODE_BRECEP] DEFAULT ((0)) NOT NULL,
    [CODE_BR_FR]     NVARCHAR (12)   NOT NULL,
    [CODE_ARTICLE]   DECIMAL (18)    NOT NULL,
    [QTE_LG_BR_FR]   DECIMAL (18, 3) NOT NULL,
    [PRIX_ART_BR_FR] DECIMAL (18, 3) NOT NULL,
    CONSTRAINT [PK_TRACE_LG_BR_FR] PRIMARY KEY CLUSTERED ([ORDRE] ASC, [CODE_BRECEP] ASC, [CODE_ARTICLE] ASC),
    CONSTRAINT [FK_TRACE_LG_BR_FR_ARTICLE] FOREIGN KEY ([CODE_ARTICLE]) REFERENCES [dbo].[ARTICLE] ([CODE_ARTICLE])
);
