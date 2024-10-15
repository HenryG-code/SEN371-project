class Record {
    constructor(recordID, dateCreated, description) {
        this._recordID = recordID;
        this._dateCreated = dateCreated;
        this._description = description;
    }

    // Getters
    get recordID() {
        return this._recordID;
    }

    get dateCreated() {
        return this._dateCreated;
    }

    get description() {
        return this._description;
    }

    // Display method
    displayRecord() {
        console.log(`Record ID: ${this._recordID}`);
        console.log(`Date Created: ${this._dateCreated}`);
        console.log(`Description: ${this._description}`);
    }
}
