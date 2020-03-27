drop table VotesForCandidates;
drop table Candidates;
drop table VoteUsers;
drop table Party;
drop table Region;
drop table DistrictElectoralCommission;
drop table Voivodeship;

create table VoteUsers
(
	Id integer identity primary key,
	UserName text,
	UserSurname text,
	Pesel integer,
	IdRegion integer references Region(Id),
	Domicile text, --miejsce zameldowania
	PostCode text
);

create table Candidates
(
	Id integer identity primary key,
	CandidateName text,
	CandidateSurname text,
	Pesel integer,
	IdParty integer references Party(Id),
	PartyName text,
	NumberOnPartyList integer
);

create table VotesForCandidates
(
	Id integer identity primary key,
	IdVoteUsers integer references VoteUsers(Id),
	IdCandidates integer references Candidates(Id),
	IdDisctrict integer references DistrictElectoralCommission(Id)
);

create table Party
(
	Id integer identity primary key,
	PartyName text,
	PoliticalAffiliation text
);

create table Region
(
	Id integer identity primary key,
	RegionName text,
	IdVoivodeship integer references Voivodeship(Id)
);

create table DistrictElectoralCommission
(
	Id integer identity primary key,
	IdRegion integer references Region(Id),
	Address text,
	Postcode text
);

create table Voivodeship
(
	Id integer identity primary key,
	VoivodeshipName text
);
