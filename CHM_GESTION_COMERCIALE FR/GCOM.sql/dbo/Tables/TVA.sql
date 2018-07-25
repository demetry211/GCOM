﻿CREATE TABLE [dbo].[TVA] (
    [CODE_TVA] DECIMAL (18)   IDENTITY (1, 1) NOT NULL,
    [TAUX_TVA] DECIMAL (5, 2) NULL,
    CONSTRAINT [PK_TVA] PRIMARY KEY CLUSTERED ([CODE_TVA] ASC)
);
