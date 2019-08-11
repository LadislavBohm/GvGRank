(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./$$_lazy_route_resource lazy recursive":
/*!******************************************************!*\
  !*** ./$$_lazy_route_resource lazy namespace object ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/app.component.html":
/*!**************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/app.component.html ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row text-center justify-content-center\">\r\n  <div class=\"col-md-5\">\r\n    <div class=\"card\">\r\n      <h1 class=\"card-title text-center\">Vote</h1>\r\n      <div class=\"card-body\">\r\n        <VOTE-COMPONENT></VOTE-COMPONENT>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n<br />\r\n<br />\r\n\r\n<div class=\"row\">\r\n  <div class=\"col-md-6\">\r\n    <div class=\"card force-card-height \">\r\n      <h1 class=\"card-title text-center\">Leaderboard</h1>\r\n      <div class=\"scrollable\">\r\n        <div class=\"card-body\">\r\n          <LEADERBOARD-COMPONENT></LEADERBOARD-COMPONENT>\r\n        </div>\r\n      </div>\r\n      </div>\r\n    </div>\r\n\r\n  <div class=\"col-md-6\">\r\n    <div class=\"card force-card-height\">\r\n      <h1 class=\"card-title text-center\">Recent Votes</h1>\r\n        <div class=\"card-body\">\r\n          <RECENT-COMPONENT></RECENT-COMPONENT>\r\n        </div>\r\n      </div>\r\n    </div>\r\n</div>\r\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/leaderboard/leaderboard.component.html":
/*!**********************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/leaderboard/leaderboard.component.html ***!
  \**********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"input-group\">\r\n  <input type=\"text\" [(ngModel)]='playerFilter' class=\"form-control\" placeholder=\"Filter by name...\" aria-label=\"Player's name\" aria-describedby=\"basic-addon2\">\r\n  <div class=\"input-group-append\">\r\n    <button class=\"btn btn-secondary\" type=\"button\" (click)='clear()'>Clear</button>\r\n  </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<p *ngFor=\"let player of (playerFilter) ? filterList(leaderboard) : leaderboard\">\r\n  {{player}}\r\n</p>\r\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/recent/recent.component.html":
/*!************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/recent/recent.component.html ***!
  \************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"input-group\">\r\n  <input type=\"text\" [(ngModel)]='playerFilter' (keyup.enter)='search()' class=\"form-control\" placeholder=\"Filter by name...\" aria-label=\"Player's name\" aria-describedby=\"basic-addon2\">\r\n  <div class=\"input-group-append\">\r\n    <button class=\"btn btn-secondary\" type=\"button\" (click)='search()'>Search</button>\r\n    <button class=\"btn btn-secondary\" type=\"button\" (click)='reset()'>Reset</button>\r\n  </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<p *ngFor=\"let vote of (filteringResults) ? filteredRecentVotes : recentVotes\">\r\n  {{vote[0]}} > {{vote[1]}}\r\n</p>\r\n\r\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/vote/vote.component.html":
/*!********************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/vote/vote.component.html ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<button class=\"btn btn-primary btn-lg\" (click)='vote1()'>\r\n  {{player1Name}}\r\n</button>\r\n\r\nor\r\n\r\n<button class=\"btn btn-danger btn-lg\" (click)='vote2()'>\r\n  {{player2Name}}\r\n</button>\r\n\r\n<p *ngIf=\"voteCount != -1\">{{voteCount}} total votes. <u (click)='getVote()'>Skip vote.</u></p>\r\n"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var AppComponent = /** @class */ (function () {
    function AppComponent() {
    }
    AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-root',
            template: __webpack_require__(/*! raw-loader!./app.component.html */ "./node_modules/raw-loader/index.js!./src/app/app.component.html")
        })
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _vote_vote_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./vote/vote.component */ "./src/app/vote/vote.component.ts");
/* harmony import */ var _leaderboard_leaderboard_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./leaderboard/leaderboard.component */ "./src/app/leaderboard/leaderboard.component.ts");
/* harmony import */ var _recent_recent_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./recent/recent.component */ "./src/app/recent/recent.component.ts");









var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_4__["NgModule"])({
            declarations: [_app_component__WEBPACK_IMPORTED_MODULE_5__["AppComponent"], _vote_vote_component__WEBPACK_IMPORTED_MODULE_6__["VoteComponent"], _leaderboard_leaderboard_component__WEBPACK_IMPORTED_MODULE_7__["LeaderboardComponent"], _recent_recent_component__WEBPACK_IMPORTED_MODULE_8__["RecentComponent"]],
            imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"], _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormsModule"], _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClientModule"]],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_5__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/leaderboard/leaderboard.component.ts":
/*!******************************************************!*\
  !*** ./src/app/leaderboard/leaderboard.component.ts ***!
  \******************************************************/
/*! exports provided: LeaderboardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LeaderboardComponent", function() { return LeaderboardComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");



var LeaderboardComponent = /** @class */ (function () {
    /*
     * Possible solutions for this...
     *   1) Refresh the leaderboard every X seconds
     *   2) Manual refresh button only
     *   3) Get a hash every X seconds, compare, update if needed.
     *   4) Server sends new leaderboard when the order is changed
     *      4.5) Hard mode -> only send list changes
     */
    function LeaderboardComponent(http) {
        this.http = http;
        this.api = "https://gvgrank.azurewebsites.net/api/leaderboard";
        //setInterval(() => this.getLeaderboard(), 60000);
    }
    LeaderboardComponent.prototype.ngOnInit = function () {
        this.getLeaderboard();
    };
    // UTILITY
    LeaderboardComponent.prototype.numberArray = function (arr) {
        for (var i = 0; i < arr.length; i++) {
            arr[i] = (i + 1) + ') ' + arr[i];
        }
        return arr;
    };
    LeaderboardComponent.prototype.clear = function () {
        this.playerFilter = '';
    };
    LeaderboardComponent.prototype.filterList = function (arr) {
        var _this = this;
        //return arr.filter(x => x.includes(this.playerFilter));
        return arr.filter(function (x) { return x.toLowerCase().includes(_this.playerFilter.toLowerCase()); });
    };
    // API
    LeaderboardComponent.prototype.getLeaderboard = function () {
        var _this = this;
        this.http.get(this.api).subscribe(function (response) {
            _this.leaderboard = _this.numberArray(response);
        }, function (error) {
            console.log(error.message);
            _this.leaderboard = ['Failed to load leaderboard.'];
        });
    };
    LeaderboardComponent.ctorParameters = function () { return [
        { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
    ]; };
    LeaderboardComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'LEADERBOARD-COMPONENT',
            template: __webpack_require__(/*! raw-loader!./leaderboard.component.html */ "./node_modules/raw-loader/index.js!./src/app/leaderboard/leaderboard.component.html")
        })
    ], LeaderboardComponent);
    return LeaderboardComponent;
}());



/***/ }),

/***/ "./src/app/recent/recent.component.ts":
/*!********************************************!*\
  !*** ./src/app/recent/recent.component.ts ***!
  \********************************************/
/*! exports provided: RecentComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RecentComponent", function() { return RecentComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _aspnet_signalr__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @aspnet/signalr */ "./node_modules/@aspnet/signalr/dist/esm/index.js");




var RecentComponent = /** @class */ (function () {
    function RecentComponent(http) {
        var _this = this;
        this.http = http;
        this.apiRecent = "https://gvgrank.azurewebsites.net/api/recentvotes";
        this.signalrConn = "https://gvgrank.azurewebsites.net/recentvote";
        this.count = 14; // Number of entries to display, dictated by card size
        this.filteringResults = false;
        // SIGNALR
        this.startConnection = function () {
            _this.hubConnection = new _aspnet_signalr__WEBPACK_IMPORTED_MODULE_3__["HubConnectionBuilder"]()
                .withUrl(_this.signalrConn, {
                skipNegotiation: true,
                transport: _aspnet_signalr__WEBPACK_IMPORTED_MODULE_3__["HttpTransportType"].WebSockets // ^
            } // ^
            )
                .build();
            _this.hubConnection
                .start()
                .then(function () { return console.log('SignalR Connection started'); })
                .catch(function (err) { return console.log('SignalR  Connection failed: ' + err); });
        };
        this.addTransferChartDataListener = function () {
            _this.hubConnection.on('recentvote', function (data) {
                _this.update(data);
            });
        };
    }
    RecentComponent.prototype.ngOnInit = function () {
        this.startConnection();
        this.addTransferChartDataListener();
        this.getRecentVotes();
    };
    // UTILITY
    RecentComponent.prototype.update = function (vote) {
        if (this.recentVotes.length == 14) {
            this.recentVotes.pop();
        }
        this.recentVotes.unshift(vote);
    };
    RecentComponent.prototype.search = function () {
        if (this.playerFilter) {
            this.filteringResults = true;
            this.getRecentVotes();
        }
    };
    RecentComponent.prototype.reset = function () {
        this.filteringResults = false;
        this.playerFilter = '';
    };
    // API
    RecentComponent.prototype.getRecentVotes = function () {
        var _this = this;
        var apiString = this.apiRecent + '?count=' + this.count;
        if (this.filteringResults)
            apiString += '&player=' + this.playerFilter;
        this.http.get(apiString).subscribe(function (response) {
            (_this.filteringResults) ? _this.filteredRecentVotes = response : _this.recentVotes = response;
        }, function (error) {
            console.log(error.message);
            (_this.filteringResults) ? _this.filteredRecentVotes = [['Failed to load recent votes', '']] : _this.recentVotes = [['Failed to load recent votes', '']];
        });
    };
    RecentComponent.ctorParameters = function () { return [
        { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
    ]; };
    RecentComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'RECENT-COMPONENT',
            template: __webpack_require__(/*! raw-loader!./recent.component.html */ "./node_modules/raw-loader/index.js!./src/app/recent/recent.component.html")
        })
    ], RecentComponent);
    return RecentComponent;
}());



/***/ }),

/***/ "./src/app/vote/vote.component.ts":
/*!****************************************!*\
  !*** ./src/app/vote/vote.component.ts ***!
  \****************************************/
/*! exports provided: VoteComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "VoteComponent", function() { return VoteComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");



var VoteComponent = /** @class */ (function () {
    function VoteComponent(http) {
        this.http = http;
        this.apiVote = "https://gvgrank.azurewebsites.net/api/vote";
        this.apiVCount = "https://gvgrank.azurewebsites.net/api/voteCount";
        //private apiVote:   string = "https://localhost:44329/api/vote";
        //private apiVCount: string = "https://localhost:44329/api/voteCount";
        this.player1Name = 'Loading...';
        this.player2Name = 'Loading...';
        this.voteCount = -1; // Value of -1 will hide the element
    }
    VoteComponent.prototype.ngOnInit = function () {
        this.getVoteCount();
        this.getVote();
    };
    // UTILITY
    VoteComponent.prototype.vote1 = function () {
        this.vote(this.player1Id, this.player2Id);
    };
    VoteComponent.prototype.vote2 = function () {
        this.vote(this.player2Id, this.player1Id);
    };
    VoteComponent.prototype.vote = function (winId, loseId) {
        this.postVote({ WinId: winId, LoseId: loseId });
        this.player1Name = ' Loading...';
        this.player2Name = ' Loading...';
        this.player1Id = 0;
        this.player2Id = 0;
        this.getVoteCount();
        this.getVote();
    };
    // API
    VoteComponent.prototype.getVoteCount = function () {
        var _this = this;
        this.http.get(this.apiVCount).subscribe(function (response) { return _this.voteCount = response; }, function (error) {
            _this.voteCount = -1; // Value of -1 will hide the element
            console.log(error.message);
        });
    };
    VoteComponent.prototype.getVote = function () {
        var _this = this;
        this.http.get(this.apiVote).subscribe(function (response) {
            _this.player1Name = response.name1;
            _this.player2Name = response.name2;
            _this.player1Id = response.id1;
            _this.player2Id = response.id2;
        }, function (error) {
            console.log(error.message);
            _this.player1Name = 'ERROR';
            _this.player2Name = 'ERROR';
            _this.player1Id = 0;
            _this.player2Id = 0;
        });
    };
    VoteComponent.prototype.postVote = function (vote) {
        this.http.post(this.apiVote, JSON.stringify(vote), {
            headers: new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpHeaders"]({
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin': '*'
            })
        }).subscribe();
    };
    VoteComponent.ctorParameters = function () { return [
        { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
    ]; };
    VoteComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'VOTE-COMPONENT',
            template: __webpack_require__(/*! raw-loader!./vote.component.html */ "./node_modules/raw-loader/index.js!./src/app/vote/vote.component.html")
        })
    ], VoteComponent);
    return VoteComponent;
}());



/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var environment = {
    production: false
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.error(err); });


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\nikit\source\repos\GvGRank\GvGRank-Client\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main-es5.js.map