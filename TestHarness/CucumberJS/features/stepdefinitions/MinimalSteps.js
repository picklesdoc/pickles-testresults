'use strict';

var assert = require('assert');

module.exports = function() {

  this.Then(/^passing step$/, function (callback) {
    // nothing to be done here
    callback();
  });

  this.Then(/^inconclusive step$/, function (callback) {
    // we want pending here
    callback.pending();
  });

  this.Then(/^failing step$/, function (callback) {
    assert.equal("true", "false");
    callback();
  });
};
