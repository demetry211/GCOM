﻿CREATE TABLE [dbo].[VEHICULE] (
    [CODE_VEHICULE] DECIMAL (18)  IDENTITY (1, 1) NOT NULL,
    [MATRICULE]     NVARCHAR (50) NULL,
    [CODE_MARQUE]   DECIMAL (18)  NOT NULL,
    [CODE_CLIENT]   DECIMAL (18)  NOT NULL,
    [GAMME]         NVARCHAR (50) NULL,
    [TYPE]          NVARCHAR (50) NULL,
    [PUISSANCE]     INT           NULL,
    [CYLINDRE]      INT           NULL,
    CONSTRAINT [PK_VEHICULE] PRIMARY KEY CLUSTERED ([CODE_VEHICULE] ASC),
    CONSTRAINT [FK_VEHICULE_CLIENT] FOREIGN KEY ([CODE_CLIENT]) REFERENCES [dbo].[CLIENT] ([CODE_CLIENT])
);


GO
ALTER TABLE [dbo].[VEHICULE] NOCHECK CONSTRAINT [FK_VEHICULE_CLIENT];

