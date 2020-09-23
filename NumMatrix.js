var NumMatrix = function(A) {
    const rs = A.length;
    const cs = !rs ? 0 : A[0].length;
    const B = [];
    for (let r = 0; r <= rs; ++r) 
        B.push(new Array(cs + 1).fill(0));
    for (let r = 1; r <= rs; ++r)
        for (let c = 1; c <= cs; ++c)
            B[r][c] = -B[r - 1][c - 1] + B[r - 1][c] + B[r][c - 1] + A[r - 1][c - 1];
    this._B = B;
};
NumMatrix.prototype.sumRegion = function(r0, c0, r1, c1) {
    ++r0; ++c0; ++r1; ++c1;
    return this._B[r1][c1] - this._B[r0 - 1][c1] - this._B[r1][c0 - 1] + this._B[r0 - 1][c0 - 1];
};