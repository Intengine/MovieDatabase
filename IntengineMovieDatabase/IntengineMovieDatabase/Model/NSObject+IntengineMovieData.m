//
//  NSObject+IntengineMovieData.m
//  IntengineMovieDatabase
//
//  Created by Sylwester Pilarz on 11/10/2018.
//  Copyright © 2018 Intengine. All rights reserved.
//

#import "NSObject+IntengineMovieData.h"

@implementation IntengineMovieData

-(id)initWithTitle:(NSString *)title rating:(float)rating {
    if ((self = [super init])) {
        self.title = title;
        self.rating = rating;
    }
    return self;
}

@end
