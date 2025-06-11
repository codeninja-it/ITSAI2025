CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;
CREATE TABLE "contatti" (
    "IdContatto" INTEGER NOT NULL CONSTRAINT "PK_contatti" PRIMARY KEY AUTOINCREMENT,
    "Nome" TEXT NOT NULL,
    "Cognome" TEXT NOT NULL,
    "Email" TEXT NOT NULL
);

CREATE TABLE "progetti" (
    "IdProgetto" INTEGER NOT NULL CONSTRAINT "PK_progetti" PRIMARY KEY AUTOINCREMENT,
    "CommittenteIdContatto" INTEGER NOT NULL,
    "Titolo" TEXT NOT NULL,
    "Perimetro" TEXT NOT NULL,
    "Creazione" TEXT NOT NULL,
    CONSTRAINT "FK_progetti_contatti_CommittenteIdContatto" FOREIGN KEY ("CommittenteIdContatto") REFERENCES "contatti" ("IdContatto") ON DELETE CASCADE
);

CREATE TABLE "messaggi" (
    "IdMessaggio" INTEGER NOT NULL CONSTRAINT "PK_messaggi" PRIMARY KEY AUTOINCREMENT,
    "DaIdContatto" INTEGER NOT NULL,
    "AIdContatto" INTEGER NOT NULL,
    "Testo" TEXT NOT NULL,
    "ProgettoIdProgetto" INTEGER NULL,
    CONSTRAINT "FK_messaggi_contatti_AIdContatto" FOREIGN KEY ("AIdContatto") REFERENCES "contatti" ("IdContatto") ON DELETE CASCADE,
    CONSTRAINT "FK_messaggi_contatti_DaIdContatto" FOREIGN KEY ("DaIdContatto") REFERENCES "contatti" ("IdContatto") ON DELETE CASCADE,
    CONSTRAINT "FK_messaggi_progetti_ProgettoIdProgetto" FOREIGN KEY ("ProgettoIdProgetto") REFERENCES "progetti" ("IdProgetto")
);

CREATE TABLE "richieste" (
    "IdRichiesta" INTEGER NOT NULL CONSTRAINT "PK_richieste" PRIMARY KEY AUTOINCREMENT,
    "ProgettoIdProgetto" INTEGER NOT NULL,
    "Descrizione" TEXT NOT NULL,
    "Inserimento" TEXT NOT NULL,
    "Fatto" INTEGER NOT NULL,
    CONSTRAINT "FK_richieste_progetti_ProgettoIdProgetto" FOREIGN KEY ("ProgettoIdProgetto") REFERENCES "progetti" ("IdProgetto") ON DELETE CASCADE
);

CREATE INDEX "IX_messaggi_AIdContatto" ON "messaggi" ("AIdContatto");

CREATE INDEX "IX_messaggi_DaIdContatto" ON "messaggi" ("DaIdContatto");

CREATE INDEX "IX_messaggi_ProgettoIdProgetto" ON "messaggi" ("ProgettoIdProgetto");

CREATE INDEX "IX_progetti_CommittenteIdContatto" ON "progetti" ("CommittenteIdContatto");

CREATE INDEX "IX_richieste_ProgettoIdProgetto" ON "richieste" ("ProgettoIdProgetto");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20250611080124_Prima', '9.0.6');

COMMIT;

