﻿CREATE TABLE [dbo].[MAGAZIN] (
    [CODE_MAG]     DECIMAL (18)   NOT NULL,
    [NOM_MAG]      NVARCHAR (MAX) NOT NULL,
    [ADRESSE_MAG]  NVARCHAR (MAX) NOT NULL,
    [TEL_MAG]      NVARCHAR (MAX) NOT NULL,
    [CODE_SOCIETE] DECIMAL (18)   NOT NULL,
    [RS_SOCIETE]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_MAGAZIN] PRIMARY KEY CLUSTERED ([CODE_MAG] ASC),
    CONSTRAINT [FK_MAGAZIN_SOCIETE1] FOREIGN KEY ([CODE_SOCIETE]) REFERENCES [dbo].[SOCIETE] ([CODE_SOCIETE])
);


GO
ALTER TABLE [dbo].[MAGAZIN] NOCHECK CONSTRAINT [FK_MAGAZIN_SOCIETE1];
