//cerner_2^5_2020
var isIsomorphic = function(s, t) {
    return getPattern(s) === getPattern(t);
};

function getPattern(str) {
    const charCodes = {};
    let pattern = '';
    for (let i = 0; i < str.length; i++) {
        if (charCodes[str[i]] === undefined) charCodes[str[i]] = i;
        pattern = `${pattern}${charCodes[str[i]]}`;
    }
    return pattern;
}